using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Restriction
    {
        /// <summary>
        /// Gets or sets the ignored.
        /// </summary>
        /// <value>
        /// The ignored.
        /// </value>
        [J("ignored", NullValueHandling = N.Ignore)] public string Ignored { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [J("tags")] public List<long> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }

        /// <summary>
        /// Gets or sets the restriction required.
        /// </summary>
        /// <value>
        /// The restriction required.
        /// </value>
        [J("required", NullValueHandling = N.Ignore)] public string RestrictionRequired { get; set; }
    }
}
