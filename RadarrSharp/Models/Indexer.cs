using RadarrSharp.Enums;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Indexer
    {
        /// <summary>
        /// Gets or sets a value indicating whether [enable RSS].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable RSS]; otherwise, <c>false</c>.
        /// </value>
        [J("enableRss")] public bool EnableRss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable search]; otherwise, <c>false</c>.
        /// </value>
        [J("enableSearch")] public bool EnableSearch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports RSS].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports RSS]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsRss")] public bool SupportsRss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports search]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsSearch")] public bool SupportsSearch { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [J("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        [J("fields")] public IList<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets the name of the implementation.
        /// </summary>
        /// <value>
        /// The name of the implementation.
        /// </value>
        [J("implementationName")] public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or sets the implementation.
        /// </summary>
        /// <value>
        /// The implementation.
        /// </value>
        [J("implementation")] public string Implementation { get; set; }

        /// <summary>
        /// Gets or sets the configuration contract.
        /// </summary>
        /// <value>
        /// The configuration contract.
        /// </value>
        [J("configContract")] public string ConfigContract { get; set; }

        /// <summary>
        /// Gets or sets the information link.
        /// </summary>
        /// <value>
        /// The information link.
        /// </value>
        [J("infoLink")] public string InfoLink { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
