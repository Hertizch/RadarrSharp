using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Release
{
    /// <summary>
    /// Release endpoint client
    /// </summary>
    public class Release : IRelease
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Release"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Release(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets releases from Radarr's search cache (30 minute cache)
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Release>> GetReleases()
        {
            var json = await _radarrClient.GetJson($"/release");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Release>>(json, Converter.Settings));
        }

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Radarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns></returns>
        public async Task<IList<Models.Release>> AddRelease(string guid)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["guid"] = guid
            });

            var json = await _radarrClient.PostJson($"/release", parameter, "POST");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Release>>(json, Converter.Settings));
        }
    }
}
