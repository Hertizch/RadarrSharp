using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// SystemStatus endpoint client
    /// </summary>
    public class SystemStatus : ISystemStatus
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public SystemStatus(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns>Data.SystemStatus</returns>
        public async Task<Data.SystemStatus> GetSystemStatus()
        {
            var json = await _radarrClient.GetJson("/system/status");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.SystemStatus>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
