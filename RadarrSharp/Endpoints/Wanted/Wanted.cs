using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Wanted
{
    /// <summary>
    /// Wanted endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Wanted.IWanted" />
    public class Wanted : IWanted
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wanted" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Wanted(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns movies that has not achieved it's cutoff quality
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 20</param>
        /// <returns></returns>
        public async Task<Models.Wanted> GetCutoffUnmet(int page = 1, int pageSize = 20)
        {
            var param = new Dictionary<string, object>
            {
                { "page", page },
                { "pageSize", pageSize }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/wanted/cutoff{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Wanted>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns movies that has not been downloaded
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 20</param>
        /// <returns></returns>
        public async Task<Models.Wanted> GetMissing(int page = 1, int pageSize = 20)
        {
            var param = new Dictionary<string, object>
            {
                { "page", page },
                { "pageSize", pageSize }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/wanted/missing{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Wanted>(json, Converter.Settings));
        }
    }
}
