using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DownloadClient
    {
        /// <summary>
        /// Gets or sets the downloaded movies folder.
        /// </summary>
        /// <value>
        /// The downloaded movies folder.
        /// </value>
        [J("downloadedMoviesFolder")] public string DownloadedMoviesFolder { get; set; }

        /// <summary>
        /// Gets or sets the download client working folders.
        /// </summary>
        /// <value>
        /// The download client working folders.
        /// </value>
        [J("downloadClientWorkingFolders")] public string DownloadClientWorkingFolders { get; set; }

        /// <summary>
        /// Gets or sets the downloaded movies scan interval.
        /// </summary>
        /// <value>
        /// The downloaded movies scan interval.
        /// </value>
        [J("downloadedMoviesScanInterval")] public long DownloadedMoviesScanInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable completed download handling].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable completed download handling]; otherwise, <c>false</c>.
        /// </value>
        [J("enableCompletedDownloadHandling")] public bool EnableCompletedDownloadHandling { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remove completed downloads].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [remove completed downloads]; otherwise, <c>false</c>.
        /// </value>
        [J("removeCompletedDownloads")] public bool RemoveCompletedDownloads { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic redownload failed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic redownload failed]; otherwise, <c>false</c>.
        /// </value>
        [J("autoRedownloadFailed")] public bool AutoRedownloadFailed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remove failed downloads].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [remove failed downloads]; otherwise, <c>false</c>.
        /// </value>
        [J("removeFailedDownloads")] public bool RemoveFailedDownloads { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
