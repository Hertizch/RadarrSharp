using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SelectOption
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [J("value")] public long Value { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }
    }
}
