using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MediaManagement
    {
        /// <summary>
        /// Gets or sets a value indicating whether [automatic unmonitor previously downloaded episodes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic unmonitor previously downloaded episodes]; otherwise, <c>false</c>.
        /// </value>
        [J("autoUnmonitorPreviouslyDownloadedEpisodes")] public bool AutoUnmonitorPreviouslyDownloadedEpisodes { get; set; }

        /// <summary>
        /// Gets or sets the recycle bin.
        /// </summary>
        /// <value>
        /// The recycle bin.
        /// </value>
        [J("recycleBin")] public string RecycleBin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic download propers].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic download propers]; otherwise, <c>false</c>.
        /// </value>
        [J("autoDownloadPropers")] public bool AutoDownloadPropers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [create empty series folders].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [create empty series folders]; otherwise, <c>false</c>.
        /// </value>
        [J("createEmptySeriesFolders")] public bool CreateEmptySeriesFolders { get; set; }

        /// <summary>
        /// Gets or sets the file date.
        /// </summary>
        /// <value>
        /// The file date.
        /// </value>
        [J("fileDate")] public string FileDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic rename folders].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic rename folders]; otherwise, <c>false</c>.
        /// </value>
        [J("autoRenameFolders")] public bool AutoRenameFolders { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [paths default static].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [paths default static]; otherwise, <c>false</c>.
        /// </value>
        [J("pathsDefaultStatic")] public bool PathsDefaultStatic { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set permissions linux].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set permissions linux]; otherwise, <c>false</c>.
        /// </value>
        [J("setPermissionsLinux")] public bool SetPermissionsLinux { get; set; }

        /// <summary>
        /// Gets or sets the file chmod.
        /// </summary>
        /// <value>
        /// The file chmod.
        /// </value>
        [J("fileChmod")] public string FileChmod { get; set; }

        /// <summary>
        /// Gets or sets the folder chmod.
        /// </summary>
        /// <value>
        /// The folder chmod.
        /// </value>
        [J("folderChmod")] public string FolderChmod { get; set; }

        /// <summary>
        /// Gets or sets the chown user.
        /// </summary>
        /// <value>
        /// The chown user.
        /// </value>
        [J("chownUser")] public string ChownUser { get; set; }

        /// <summary>
        /// Gets or sets the chown group.
        /// </summary>
        /// <value>
        /// The chown group.
        /// </value>
        [J("chownGroup")] public string ChownGroup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [skip free space check when importing].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [skip free space check when importing]; otherwise, <c>false</c>.
        /// </value>
        [J("skipFreeSpaceCheckWhenImporting")] public bool SkipFreeSpaceCheckWhenImporting { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [copy using hardlinks].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [copy using hardlinks]; otherwise, <c>false</c>.
        /// </value>
        [J("copyUsingHardlinks")] public bool CopyUsingHardlinks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [import extra files].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [import extra files]; otherwise, <c>false</c>.
        /// </value>
        [J("importExtraFiles")] public bool ImportExtraFiles { get; set; }

        /// <summary>
        /// Gets or sets the extra file extensions.
        /// </summary>
        /// <value>
        /// The extra file extensions.
        /// </value>
        [J("extraFileExtensions")] public string ExtraFileExtensions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable media information].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable media information]; otherwise, <c>false</c>.
        /// </value>
        [J("enableMediaInfo")] public bool EnableMediaInfo { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
