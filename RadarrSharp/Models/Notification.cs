using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Notification
    {
        /// <summary>
        /// Gets or sets a value indicating whether [on grab].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on grab]; otherwise, <c>false</c>.
        /// </value>
        [J("onGrab")] public bool OnGrab { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on download].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on download]; otherwise, <c>false</c>.
        /// </value>
        [J("onDownload")] public bool OnDownload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on upgrade].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on upgrade]; otherwise, <c>false</c>.
        /// </value>
        [J("onUpgrade")] public bool OnUpgrade { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on rename].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on rename]; otherwise, <c>false</c>.
        /// </value>
        [J("onRename")] public bool OnRename { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports on grab].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports on grab]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsOnGrab")] public bool SupportsOnGrab { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports on download].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports on download]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsOnDownload")] public bool SupportsOnDownload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports on upgrade].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports on upgrade]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsOnUpgrade")] public bool SupportsOnUpgrade { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports on rename].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports on rename]; otherwise, <c>false</c>.
        /// </value>
        [J("supportsOnRename")] public bool SupportsOnRename { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [J("tags")] public List<object> Tags { get; set; }

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
        [J("fields")] public List<Field> Fields { get; set; }

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
        [J("id")] public int Id { get; set; }
    }
}
