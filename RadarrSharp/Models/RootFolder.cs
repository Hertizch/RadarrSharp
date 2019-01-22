using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RootFolder
    {
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the free space.
        /// </summary>
        /// <value>
        /// The free space.
        /// </value>
        [J("freeSpace")] public long FreeSpace { get; set; }

        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        /// <value>
        /// The total space.
        /// </value>
        [J("totalSpace")] public long TotalSpace { get; set; }

        /// <summary>
        /// Gets or sets the unmapped folders.
        /// </summary>
        /// <value>
        /// The unmapped folders.
        /// </value>
        [J("unmappedFolders", NullValueHandling = N.Ignore)] public IList<UnmappedFolder> UnmappedFolders { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }
    }
}
