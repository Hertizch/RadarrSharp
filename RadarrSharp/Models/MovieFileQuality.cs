using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
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
        [J("hardcodedSubs", NullValueHandling = N.Ignore)] public string HardcodedSubs { get; set; }

        /// <summary>
        /// Gets or sets the custom formats.
        /// </summary>
        /// <value>
        /// The custom formats.
        /// </value>
        [J("customFormats")] public List<CustomFormat> CustomFormats { get; set; }
    }
}
