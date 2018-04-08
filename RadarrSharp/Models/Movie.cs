using RadarrSharp.Enums;
using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Movie
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the alternative titles.
        /// </summary>
        /// <value>
        /// The alternative titles.
        /// </value>
        [J("alternativeTitles")] public IList<AlternativeTitle> AlternativeTitles { get; set; }

        /// <summary>
        /// Gets or sets the secondary year source identifier.
        /// </summary>
        /// <value>
        /// The secondary year source identifier.
        /// </value>
        [J("secondaryYearSourceId")] public long SecondaryYearSourceId { get; set; }

        /// <summary>
        /// Gets or sets the sort title.
        /// </summary>
        /// <value>
        /// The sort title.
        /// </value>
        [J("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// Gets or sets the size on disk.
        /// </summary>
        /// <value>
        /// The size on disk.
        /// </value>
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the in cinemas.
        /// </summary>
        /// <value>
        /// The in cinemas.
        /// </value>
        [J("inCinemas", NullValueHandling = N.Ignore)] public DateTimeOffset? InCinemas { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [J("images")] public IList<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        [J("website", NullValueHandling = N.Ignore)] public string Website { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie" /> is downloaded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if downloaded; otherwise, <c>false</c>.
        /// </value>
        [J("downloaded")] public bool Downloaded { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has file.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has file; otherwise, <c>false</c>.
        /// </value>
        [J("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// Gets or sets you tube trailer identifier.
        /// </summary>
        /// <value>
        /// You tube trailer identifier.
        /// </value>
        [J("youTubeTrailerId", NullValueHandling = N.Ignore)] public string YouTubeTrailerId { get; set; }

        /// <summary>
        /// Gets or sets the studio.
        /// </summary>
        /// <value>
        /// The studio.
        /// </value>
        [J("studio", NullValueHandling = N.Ignore)] public string Studio { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        [J("profileId")] public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the state of the path.
        /// </summary>
        /// <value>
        /// The state of the path.
        /// </value>
        [J("pathState")] public PathState PathState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the minimum availability.
        /// </summary>
        /// <value>
        /// The minimum availability.
        /// </value>
        [J("minimumAvailability")] public MinimumAvailability MinimumAvailability { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is available; otherwise, <c>false</c>.
        /// </value>
        [J("isAvailable")] public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        /// <value>
        /// The name of the folder.
        /// </value>
        [J("folderName")] public string FolderName { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [J("runtime")] public long Runtime { get; set; }

        /// <summary>
        /// Gets or sets the last information synchronize.
        /// </summary>
        /// <value>
        /// The last information synchronize.
        /// </value>
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// Gets or sets the clean title.
        /// </summary>
        /// <value>
        /// The clean title.
        /// </value>
        [J("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the TMDB identifier.
        /// </summary>
        /// <value>
        /// The TMDB identifier.
        /// </value>
        [J("tmdbId")] public long TmdbId { get; set; }

        /// <summary>
        /// Gets or sets the title slug.
        /// </summary>
        /// <value>
        /// The title slug.
        /// </value>
        [J("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [J("genres")] public IList<object> Genres { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [J("tags")] public IList<object> Tags { get; set; }

        /// <summary>
        /// Gets or sets the added.
        /// </summary>
        /// <value>
        /// The added.
        /// </value>
        [J("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        /// <value>
        /// The ratings.
        /// </value>
        [J("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// Gets or sets the quality profile identifier.
        /// </summary>
        /// <value>
        /// The quality profile identifier.
        /// </value>
        [J("qualityProfileId")] public long QualityProfileId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }

        /// <summary>
        /// Gets or sets the movie file.
        /// </summary>
        /// <value>
        /// The movie file.
        /// </value>
        [J("movieFile", NullValueHandling = N.Ignore)] public MovieFile MovieFile { get; set; }

        /// <summary>
        /// Gets or sets the physical release.
        /// </summary>
        /// <value>
        /// The physical release.
        /// </value>
        [J("physicalRelease", NullValueHandling = N.Ignore)] public DateTimeOffset? PhysicalRelease { get; set; }

        /// <summary>
        /// Gets or sets the physical release note.
        /// </summary>
        /// <value>
        /// The physical release note.
        /// </value>
        [J("physicalReleaseNote", NullValueHandling = N.Ignore)] public string PhysicalReleaseNote { get; set; }

        /// <summary>
        /// Gets or sets the secondary year.
        /// </summary>
        /// <value>
        /// The secondary year.
        /// </value>
        [J("secondaryYear", NullValueHandling = N.Ignore)] public long? SecondaryYear { get; set; }
    }
}
