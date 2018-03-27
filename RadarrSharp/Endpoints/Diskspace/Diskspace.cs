using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System;
using System.Diagnostics;
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
        /// Initializes a new instance of the <see cref="Diskspace" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Diskspace(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns>
        /// Models.Diskspace[]
        /// </returns>
        public async Task<Models.Diskspace[]> GetDiskspace()
        {
            var json = await _radarrClient.GetJson("/diskspace");
            return DeserializeArray(json);
        }

        /// <summary>
        /// Deserializes the array.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        private static Models.Diskspace[] DeserializeArray(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Diskspace)}.{nameof(DeserializeArray)}({json})] JSON is null");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<Models.Diskspace[]>(json, JsonHelpers.SerializerSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Diskspace)}.{nameof(DeserializeArray)}({json})] {ex}");
                return null;
            }
        }
    }
}
