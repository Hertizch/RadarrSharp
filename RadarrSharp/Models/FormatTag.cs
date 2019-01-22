using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormatTag
    {
        /// <summary>
        /// Gets or sets the raw.
        /// </summary>
        /// <value>
        /// The raw.
        /// </value>
        [J("raw")] public string Raw { get; set; }

        /// <summary>
        /// Gets or sets the type of the tag.
        /// </summary>
        /// <value>
        /// The type of the tag.
        /// </value>
        [J("tagType")] public string TagType { get; set; }

        /// <summary>
        /// Gets or sets the tag modifier.
        /// </summary>
        /// <value>
        /// The tag modifier.
        /// </value>
        [J("tagModifier")] public string TagModifier { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [J("value")] public Value Value { get; set; }
    }
}
