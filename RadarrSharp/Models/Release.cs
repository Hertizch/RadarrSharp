using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;
using RadarrSharp.Enums;
using System.Collections.Generic;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Release
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [J("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public ReleaseQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the quality weight.
        /// </summary>
        /// <value>
        /// The quality weight.
        /// </value>
        [J("qualityWeight")] public long QualityWeight { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [J("age")] public long Age { get; set; }

        /// <summary>
        /// Gets or sets the age hours.
        /// </summary>
        /// <value>
        /// The age hours.
        /// </value>
        [J("ageHours")] public double AgeHours { get; set; }

        /// <summary>
        /// Gets or sets the age minutes.
        /// </summary>
        /// <value>
        /// The age minutes.
        /// </value>
        [J("ageMinutes")] public double AgeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the indexer identifier.
        /// </summary>
        /// <value>
        /// The indexer identifier.
        /// </value>
        [J("indexerId")] public int IndexerId { get; set; }

        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [J("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the release hash.
        /// </summary>
        /// <value>
        /// The release hash.
        /// </value>
        [J("releaseHash", NullValueHandling = N.Ignore)] public string ReleaseHash { get; set; }

        /// <summary>
        /// Gets or sets the edition.
        /// </summary>
        /// <value>
        /// The edition.
        /// </value>
        [J("edition", NullValueHandling = N.Ignore)] public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [full season].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [full season]; otherwise, <c>false</c>.
        /// </value>
        [J("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [J("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// Gets or sets the movie title.
        /// </summary>
        /// <value>
        /// The movie title.
        /// </value>
        [J("movieTitle")] public string MovieTitle { get; set; }

        /// <summary>
        /// Gets or sets the episode numbers.
        /// </summary>
        /// <value>
        /// The episode numbers.
        /// </value>
        [J("episodeNumbers")] public List<object> EpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets the absolute episode numbers.
        /// </summary>
        /// <value>
        /// The absolute episode numbers.
        /// </value>
        [J("absoluteEpisodeNumbers")] public List<object> AbsoluteEpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [J("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [temporarily rejected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [temporarily rejected]; otherwise, <c>false</c>.
        /// </value>
        [J("temporarilyRejected")] public bool TemporarilyRejected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is rejected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rejected; otherwise, <c>false</c>.
        /// </value>
        [J("rejected")] public bool Rejected { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [J("tvdbId")] public long TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [J("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the rejections.
        /// </summary>
        /// <value>
        /// The rejections.
        /// </value>
        [J("rejections")] public List<string> Rejections { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [J("publishDate")] public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the comment URL.
        /// </summary>
        /// <value>
        /// The comment URL.
        /// </value>
        [J("commentUrl")] public string CommentUrl { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the information URL.
        /// </summary>
        /// <value>
        /// The information URL.
        /// </value>
        [J("infoUrl")] public string InfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the mapping result.
        /// </summary>
        /// <value>
        /// The mapping result.
        /// </value>
        [J("mappingResult")] public MappingResult MappingResult { get; set; }

        /// <summary>
        /// Gets or sets the release weight.
        /// </summary>
        /// <value>
        /// The release weight.
        /// </value>
        [J("releaseWeight")] public long ReleaseWeight { get; set; }

        /// <summary>
        /// Gets or sets the suspected movie identifier.
        /// </summary>
        /// <value>
        /// The suspected movie identifier.
        /// </value>
        [J("suspectedMovieId")] public long SuspectedMovieId { get; set; }

        /// <summary>
        /// Gets or sets the indexer flags.
        /// </summary>
        /// <value>
        /// The indexer flags.
        /// </value>
        [J("indexerFlags")] public List<string> IndexerFlags { get; set; }

        /// <summary>
        /// Gets or sets the magnet URL.
        /// </summary>
        /// <value>
        /// The magnet URL.
        /// </value>
        [J("magnetUrl")] public string MagnetUrl { get; set; }

        /// <summary>
        /// Gets or sets the information hash.
        /// </summary>
        /// <value>
        /// The information hash.
        /// </value>
        [J("infoHash")] public string InfoHash { get; set; }

        /// <summary>
        /// Gets or sets the seeders.
        /// </summary>
        /// <value>
        /// The seeders.
        /// </value>
        [J("seeders")] public int Seeders { get; set; }

        /// <summary>
        /// Gets or sets the leechers.
        /// </summary>
        /// <value>
        /// The leechers.
        /// </value>
        [J("leechers")] public int Leechers { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [J("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is daily.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is daily; otherwise, <c>false</c>.
        /// </value>
        [J("isDaily")] public bool IsDaily { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is absolute numbering.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is absolute numbering; otherwise, <c>false</c>.
        /// </value>
        [J("isAbsoluteNumbering")] public bool IsAbsoluteNumbering { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is possible special episode.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is possible special episode; otherwise, <c>false</c>.
        /// </value>
        [J("isPossibleSpecialEpisode")] public bool IsPossibleSpecialEpisode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is special.
        /// </summary>
        /// <value>
        ///   <c>true</c> if special; otherwise, <c>false</c>.
        /// </value>
        [J("special")] public bool Special { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [J("releaseGroup", NullValueHandling = N.Ignore)] public string ReleaseGroup { get; set; }
    }
}
