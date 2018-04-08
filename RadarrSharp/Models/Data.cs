using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [J("indexer", NullValueHandling = N.Ignore)] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the NZB information URL.
        /// </summary>
        /// <value>
        /// The NZB information URL.
        /// </value>
        [J("nzbInfoUrl", NullValueHandling = N.Ignore)] public string NzbInfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [J("releaseGroup", NullValueHandling = N.Ignore)] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [J("age", NullValueHandling = N.Ignore)] public string Age { get; set; }

        /// <summary>
        /// Gets or sets the age hours.
        /// </summary>
        /// <value>
        /// The age hours.
        /// </value>
        [J("ageHours", NullValueHandling = N.Ignore)] public string AgeHours { get; set; }

        /// <summary>
        /// Gets or sets the age minutes.
        /// </summary>
        /// <value>
        /// The age minutes.
        /// </value>
        [J("ageMinutes", NullValueHandling = N.Ignore)] public string AgeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>
        /// The published date.
        /// </value>
        [J("publishedDate", NullValueHandling = N.Ignore)] public DateTimeOffset? PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        [J("downloadClient", NullValueHandling = N.Ignore)] public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size", NullValueHandling = N.Ignore)] public string Size { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [J("downloadUrl", NullValueHandling = N.Ignore)] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [J("guid", NullValueHandling = N.Ignore)] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [J("tvdbId", NullValueHandling = N.Ignore)] public string TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [J("tvRageId", NullValueHandling = N.Ignore)] public string TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [J("protocol", NullValueHandling = N.Ignore)] public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the torrent information hash.
        /// </summary>
        /// <value>
        /// The torrent information hash.
        /// </value>
        [J("torrentInfoHash", NullValueHandling = N.Ignore)] public string TorrentInfoHash { get; set; }

        /// <summary>
        /// Gets or sets the dropped path.
        /// </summary>
        /// <value>
        /// The dropped path.
        /// </value>
        [J("droppedPath", NullValueHandling = N.Ignore)] public string DroppedPath { get; set; }

        /// <summary>
        /// Gets or sets the imported path.
        /// </summary>
        /// <value>
        /// The imported path.
        /// </value>
        [J("importedPath", NullValueHandling = N.Ignore)] public string ImportedPath { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        [J("reason", NullValueHandling = N.Ignore)] public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [J("message", NullValueHandling = N.Ignore)] public string Message { get; set; }
    }
}
