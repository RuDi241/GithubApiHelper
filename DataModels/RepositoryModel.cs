using Newtonsoft.Json;

namespace GithubApiHelper.DataModels
{
    /// <summary>
    /// Class that represents the data received from "https://api.github.com/repos/{Owner}/{Repo_name}"
    /// </summary>
    public class RepositoryModel
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }
        [JsonProperty(PropertyName = "owner")]
        public UserModel Owner { get; set; }
        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "fork")]
        public bool IsFork { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "forks_url")]
        public string ForksUrl { get; set; }
        [JsonProperty(PropertyName = "keys_url")]
        public string KeysUrl { get; set; }
        [JsonProperty(PropertyName = "collaborators_url")]
        public string CollaboratorsUrl { get; set; }
        [JsonProperty(PropertyName = "teams_url")]
        public string TeamsUrl { get; set; }
        [JsonProperty(PropertyName = "hooks_url")]
        public string HooksUrl { get; set; }
        [JsonProperty(PropertyName = "issue_events_url")]
        public string IssueEventsUrl { get; set; }
        [JsonProperty(PropertyName = "events_url")]
        public string EventsUrl { get; set; }
        [JsonProperty(PropertyName = "assignees_url")]
        public string AssigneesUrl { get; set; }
        [JsonProperty(PropertyName = "branches_url")]
        public string BranchesUrl { get; set; }
        [JsonProperty(PropertyName = "tags_url")]
        public string TagsUrl { get; set; }
        [JsonProperty(PropertyName = "blobs_url")]
        public string BlobsUrl { get; set; }
        [JsonProperty(PropertyName = "git_tags_url")]
        public string GitTagsUrl { get; set; }
        [JsonProperty(PropertyName = "git_refs_url")]
        public string GitRefsUrl { get; set; }
        [JsonProperty(PropertyName = "trees_url")]
        public string TreesUrl { get; set; }
        [JsonProperty(PropertyName = "statuses_url")]
        public string StatusesUrl { get; set; }
        [JsonProperty(PropertyName = "languages_url")]
        public string LanguagesUrl { get; set; }
        [JsonProperty(PropertyName = "stargazers_url")]
        public string StargazersUrl { get; set; }
        [JsonProperty(PropertyName = "contributors_url")]
        public string ContributorsUrl { get; set; }
        [JsonProperty(PropertyName = "subscribers_url")]
        public string SubscribersUrl { get; set; }
        [JsonProperty(PropertyName = "subscription_url")]
        public string SubscriptionUrl { get; set; }
        [JsonProperty(PropertyName = "commits_url")]
        public string CommitsUrl { get; set; }
        [JsonProperty(PropertyName = "git_commits_url")]
        public string GitCommitsUrl { get; set; }
        [JsonProperty(PropertyName = "comments_url")]
        public string CommentsUrl { get; set; }
        [JsonProperty(PropertyName = "issue_comment_url")]
        public string IssueCommentUrl { get; set; }
        [JsonProperty(PropertyName = "contents_url")]
        public string ContentsUrl { get; set; }
        [JsonProperty(PropertyName = "compare_url")]
        public string CompareUrl { get; set; }
        [JsonProperty(PropertyName = "merges_url")]
        public string MergesUrl { get; set; }
        [JsonProperty(PropertyName = "archive_url")]
        public string ArchiveUrl { get; set; }
        [JsonProperty(PropertyName = "downloads_url")]
        public string DownloadsUrl { get; set; }
        [JsonProperty(PropertyName = "issues_url")]
        public string IssuesUrl { get; set; }
        [JsonProperty(PropertyName = "pulls_url")]
        public string PullsUrl { get; set; }
        [JsonProperty(PropertyName = "milestones_url")]
        public string MilestonesUrl { get; set; }
        [JsonProperty(PropertyName = "notifications_url")]
        public string NotificationsUrl { get; set; }
        [JsonProperty(PropertyName = "labels_url")]
        public string LabelsUrl { get; set; }
        [JsonProperty(PropertyName = "releases_url")]
        public string ReleasesUrl { get; set; }
        [JsonProperty(PropertyName = "deployments_url")]
        public string DeploymentsUrl { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }
        [JsonProperty(PropertyName = "pushed_at")]
        public string PushedAt { get; set; }
        [JsonProperty(PropertyName = "git_url")]
        public string GitUrl { get; set; }
        [JsonProperty(PropertyName = "ssh_url")]
        public string SshUrl { get; set; }
        [JsonProperty(PropertyName = "clone_url")]
        public string CloneUrl { get; set; }
        [JsonProperty(PropertyName = "svn_url")]
        public string SvnUrl { get; set; }
        [JsonProperty(PropertyName = "has_homepage")]
        public string hasHomepage { get; set; }
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
        [JsonProperty(PropertyName = "stargazers_count")]
        public int StargazersCount { get; set; }
        [JsonProperty(PropertyName = "watchers_count")]
        public int WatchersCount { get; set; }
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        [JsonProperty(PropertyName = "has_issues")]
        public bool HasIssues  { get; set; }
        [JsonProperty(PropertyName = "has_projects")]
        public bool HasProjects { get; set; }
        [JsonProperty(PropertyName = "has_downloads")]
        public bool HasDownloads { get; set; }
        [JsonProperty(PropertyName = "has_wiki")]
        public bool HasWiki { get; set; }
        [JsonProperty(PropertyName = "has_pages")]
        public bool HasPages { get; set; }
        [JsonProperty(PropertyName = "forks_count")]
        public int ForksCount { get; set; }
        [JsonProperty(PropertyName = "mirror_url")]
        public string MirrorUrl { get; set; }
        [JsonProperty(PropertyName = "archived")]
        public bool IsArchived { get; set; }
        [JsonProperty(PropertyName = "disabled")]
        public bool IsDisabled { get; set; }
        [JsonProperty(PropertyName = "open_issues_count")]
        public int OpenIssuesCount { get; set; }
        [JsonProperty(PropertyName = "license")]
        public string License { get; set; }
        [JsonProperty(PropertyName = "forks")]
        public int Forks { get; set; }
        [JsonProperty(PropertyName = "open_issues")]
        public int OpenIssues { get; set; }
        [JsonProperty(PropertyName = "watchers")]
        public int Watchers { get; set; }
        [JsonProperty(PropertyName = "default_branch")]
        public string DefaultBranch { get; set; }
        [JsonProperty(PropertyName = "temp_clone_token")]
        public string TempCloneToken { get; set; }
        [JsonProperty(PropertyName = "network_count")]
        public int NetworkCount { get; set; }
        [JsonProperty(PropertyName = "subscribers_count")]
        public int SubscribersCount { get; set; }

    }
}
