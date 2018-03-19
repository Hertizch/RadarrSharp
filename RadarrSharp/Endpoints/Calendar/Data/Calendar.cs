using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.Calendar.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Calendar
    {
        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("inCinemas")] public DateTimeOffset InCinemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("physicalRelease")] public DateTimeOffset PhysicalRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("images")] public Image[] Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("website")] public string Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloaded")] public bool Downloaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("youTubeTrailerId")] public string YouTubeTrailerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("studio")] public string Studio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("profileId")] public long ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("runtime")] public long Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tmdbId")] public long TmdbId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("genres")] public string[] Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tags")] public object[] Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("alternativeTitles")] public string[] AlternativeTitles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("qualityProfileId")] public long QualityProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
