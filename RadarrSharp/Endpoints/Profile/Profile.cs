using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Profile
{
    /// <summary>
    /// Profile endpoint client
    /// </summary>
    public class Profile : IProfile
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Profile(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets all quality profiles
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Profile>> GetProfiles()
        {
            var json = await _radarrClient.ProcessJson("GET", "/profile");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Profile>>(json, Converter.Settings));
        }
    }
}
