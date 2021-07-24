using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GithubApiHelper.DataModels;
using Newtonsoft.Json;

namespace GithubApiHelper
{
    public class GithubClient : IApiClient
    {
        #region Consts
        private const string REPOSITORY_URI = "https://api.github.com/repos/";
        #endregion
        #region Constructors
        /// <summary>
        /// Initializes the client.
        /// </summary>
        /// <param name="TOKEN">Your personal access token. You can get one from your github in settings</param>
        /// <param name="appName">The name of your app</param>
        /// <param name="appVersion">The current version of your app</param>
        public GithubClient(string token = "", string appName = "MyApp", string appVersion = "1")
        {
            if (string.IsNullOrWhiteSpace(appName)) throw new ArgumentException("appName can't be null, empty or whitespace.");
            if (string.IsNullOrWhiteSpace(appVersion)) throw new ArgumentException("appVersion can't be null, empty or whitespace.");

            if (ReferenceEquals(HttpClient, null))
            {
                HttpClient = new HttpClient();
                HttpClient.DefaultRequestHeaders.Accept.Clear();
                HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(appName, appVersion));
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (!string.IsNullOrWhiteSpace(token))
                {
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);
                }
            }
        }
        #endregion
        #region Public Methods
        public async Task<T> GetDataAsync<T>(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Owner can't be null, empty or whitespace.");
            T result;
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(uri);
                using (var response = await HttpClient.SendAsync(request))
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new HttpRequestException("Http status code: " + response.StatusCode.ToString());
                    }
                    string responseContent = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(responseContent);
                }
            }
            return result;
        }
        #endregion
        #region Private Props
        private static HttpClient HttpClient { get; set; }
        #endregion
    }
}
