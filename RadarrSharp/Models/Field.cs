using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        [J("order")] public long Order { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [J("label")] public string Label { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [J("value", NullValueHandling = N.Ignore)] public Value? Value { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [J("type")] public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Field"/> is advanced.
        /// </summary>
        /// <value>
        ///   <c>true</c> if advanced; otherwise, <c>false</c>.
        /// </value>
        [J("advanced")] public bool Advanced { get; set; }

        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        /// <value>
        /// The help text.
        /// </value>
        [J("helpText", NullValueHandling = N.Ignore)] public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets the select options.
        /// </summary>
        /// <value>
        /// The select options.
        /// </value>
        [J("selectOptions", NullValueHandling = N.Ignore)] public IList<SelectOption> SelectOptions { get; set; }
    }
}
