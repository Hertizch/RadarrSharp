using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NetImport
    {
        /// <summary>
        /// Gets or sets the net import synchronize interval.
        /// </summary>
        /// <value>
        /// The net import synchronize interval.
        /// </value>
        [J("netImportSyncInterval")] public long NetImportSyncInterval { get; set; }

        /// <summary>
        /// Gets or sets the list synchronize level.
        /// </summary>
        /// <value>
        /// The list synchronize level.
        /// </value>
        [J("listSyncLevel")] public string ListSyncLevel { get; set; }

        /// <summary>
        /// Gets or sets the import exclusions.
        /// </summary>
        /// <value>
        /// The import exclusions.
        /// </value>
        [J("importExclusions")] public string ImportExclusions { get; set; }

        /// <summary>
        /// Gets or sets the trakt authentication token.
        /// </summary>
        /// <value>
        /// The trakt authentication token.
        /// </value>
        [J("traktAuthToken")] public string TraktAuthToken { get; set; }

        /// <summary>
        /// Gets or sets the trakt refresh token.
        /// </summary>
        /// <value>
        /// The trakt refresh token.
        /// </value>
        [J("traktRefreshToken")] public string TraktRefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the trakt token expiry.
        /// </summary>
        /// <value>
        /// The trakt token expiry.
        /// </value>
        [J("traktTokenExpiry")] public long TraktTokenExpiry { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
