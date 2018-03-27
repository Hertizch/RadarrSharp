using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

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
        [J("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the NZB information URL.
        /// </summary>
        /// <value>
        /// The NZB information URL.
        /// </value>
        [J("nzbInfoUrl")] public string NzbInfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [J("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [J("age")] public string Age { get; set; }

        /// <summary>
        /// Gets or sets the age hours.
        /// </summary>
        /// <value>
        /// The age hours.
        /// </value>
        [J("ageHours")] public string AgeHours { get; set; }

        /// <summary>
        /// Gets or sets the age minutes.
        /// </summary>
        /// <value>
        /// The age minutes.
        /// </value>
        [J("ageMinutes")] public string AgeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>
        /// The published date.
        /// </value>
        [J("publishedDate")] public DateTimeOffset PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        [J("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public string Size { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [J("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [J("tvdbId")] public string TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [J("tvRageId")] public string TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [J("protocol")] public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the torrent information hash.
        /// </summary>
        /// <value>
        /// The torrent information hash.
        /// </value>
        [J("torrentInfoHash")] public object TorrentInfoHash { get; set; }
    }
}
