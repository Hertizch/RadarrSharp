using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// Diskspace endpoint client
    /// </summary>
    public class Diskspace : IDiskspace
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Diskspace"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Diskspace(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns>Data.Diskspace[]</returns>
        public async Task<Data.Diskspace[]> GetDiskspace()
        {
            var json = await _radarrClient.GetJson("/diskspace");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Diskspace[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
