using System.Threading.Tasks;

namespace GithubApiHelper
{
    public interface IApiClient
    {
        Task<T> GetDataAsync<T>(string uri);
    }
}