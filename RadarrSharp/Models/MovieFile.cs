using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MovieFile
    {
        /// <summary>
        /// Gets or sets the movie identifier.
        /// </summary>
        /// <value>
        /// The movie identifier.
        /// </value>
        [J("movieId")] public long MovieId { get; set; }

        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        /// <value>
        /// The relative path.
        /// </value>
        [J("relativePath")] public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the date added.
        /// </summary>
        /// <value>
        /// The date added.
        /// </value>
        [J("dateAdded")] public DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        /// <value>
        /// The name of the scene.
        /// </value>
        [J("sceneName", NullValueHandling = N.Ignore)] public string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [J("releaseGroup", NullValueHandling = N.Ignore)] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public MovieFileQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the edition.
        /// </summary>
        /// <value>
        /// The edition.
        /// </value>
        [J("edition")] public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the media information.
        /// </summary>
        /// <value>
        /// The media information.
        /// </value>
        [J("mediaInfo")] public MediaInfo MediaInfo { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
