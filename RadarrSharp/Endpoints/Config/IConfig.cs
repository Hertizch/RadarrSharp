using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Config
{
    /// <summary>
    /// Config endpoint client
    /// </summary>
    public interface IConfig
    {
        /// <summary>
        /// Gets the download client configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.DownloadClient> GetDownloadClientConfig();

        /// <summary>
        /// Gets the host configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.Host> GetHostConfig();

        /// <summary>
        /// Gets the indexer configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.Indexer> GetIndexerConfig();

        /// <summary>
        /// Gets the media management configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.MediaManagement> GetMediaManagementConfig();

        /// <summary>
        /// Gets the naming configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.Naming> GetNamingConfig();

        /// <summary>
        /// Gets the net import configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.NetImport> GetNetImportConfig();

        /// <summary>
        /// Gets the UI configuration.
        /// </summary>
        /// <returns></returns>
        Task<Models.Config.Ui> GetUiConfig();
    }
}
