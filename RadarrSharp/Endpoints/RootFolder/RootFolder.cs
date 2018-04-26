using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.RootFolder
{
    /// <summary>
    /// RootFolder endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.RootFolder.IRootFolder" />
    public class RootFolder : IRootFolder
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="RootFolder"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public RootFolder(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the root folders.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.RootFolder>> GetRootFolders()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/rootFolder");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.RootFolder>>(json, Converter.Settings));
        }
    }
}
