using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// 
        /// </summary>
        [J("episodeId")] public long EpisodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("movieId")] public long MovieId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sourceTitle")] public string SourceTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public RecordQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("qualityCutoffNotMet")] public bool QualityCutoffNotMet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("date")] public DateTimeOffset Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("eventType")] public string EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("data")] public Data Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("movie")] public Movie Movie { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
