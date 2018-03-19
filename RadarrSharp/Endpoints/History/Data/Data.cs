using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// 
        /// </summary>
        [J("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("nzbInfoUrl")] public string NzbInfoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("age")] public string Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("ageHours")] public string AgeHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("ageMinutes")] public string AgeMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("publishedDate")] public DateTimeOffset PublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("size")] public string Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("guid")] public string Guid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvdbId")] public string TvdbId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvRageId")] public string TvRageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("protocol")] public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("torrentInfoHash")] public object TorrentInfoHash { get; set; }
    }
}
