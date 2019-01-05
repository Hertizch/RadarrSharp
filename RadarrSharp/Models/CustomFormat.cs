using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary></summary>
    public partial class CustomFormat
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the format tags.
        /// </summary>
        /// <value>
        /// The format tags.
        /// </value>
        [J("formatTags")] public string[] FormatTags { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
