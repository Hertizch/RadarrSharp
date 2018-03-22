using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.Movie.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MovieFileQuality
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the revision.
        /// </summary>
        /// <value>
        /// The revision.
        /// </value>
        [J("revision")] public Revision Revision { get; set; }

        /// <summary>
        /// Gets or sets the hardcoded subs.
        /// </summary>
        /// <value>
        /// The hardcoded subs.
        /// </value>
        [J("hardcodedSubs")] public string HardcodedSubs { get; set; }
    }
}
