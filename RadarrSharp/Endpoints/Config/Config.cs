using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Config
{
    /// <summary>
    /// Config endpoint client
    /// </summary>
    public class Config : IConfig
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Config(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the download client configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.DownloadClient> GetDownloadClientConfig()
        {
            var json = await _radarrClient.GetJson($"/config/downloadClient");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.DownloadClient>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the host configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Host> GetHostConfig()
        {
            var json = await _radarrClient.GetJson($"/config/host");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.Host>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the indexer configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Indexer> GetIndexerConfig()
        {
            var json = await _radarrClient.GetJson($"/config/indexer");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.Indexer>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the media management configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.MediaManagement> GetMediaManagementConfig()
        {
            var json = await _radarrClient.GetJson($"/config/mediaManagement");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.MediaManagement>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the naming configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Naming> GetNamingConfig()
        {
            var json = await _radarrClient.GetJson($"/config/naming");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.Naming>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the net import configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.NetImport> GetNetImportConfig()
        {
            var json = await _radarrClient.GetJson($"/config/netImport");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.NetImport>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the UI configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Ui> GetUiConfig()
        {
            var json = await _radarrClient.GetJson($"/config/ui");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Config.Ui>(json, Converter.Settings));
        }
    }
}
