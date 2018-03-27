using Newtonsoft.Json;
using RadarrSharp.Enums;
using RadarrSharp.Helpers;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    public class History : IHistory
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="History" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public History(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets history (grabs/failures/completed)
        /// </summary>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortKey">Movie title or Date</param>
        /// <param name="sortDirection">Sort direction</param>
        /// <returns>
        /// Models.History
        /// </returns>
        public async Task<Models.History> GetHistory(int page, [Optional] int pageSize, [Optional] string sortKey, [Optional] SortDirection sortDirection)
        {
            var json = await _radarrClient.GetJson($"/history?page={page}" +
                $"{(pageSize != 0 ? "&pageSize=" + pageSize : "")}" +
                $"{(sortKey != null ? "&sortKey=" + sortKey : "")}" +
                $"{(sortDirection != 0 ? "&sortDir=" + sortDirection.ToString().ToLower() : "")}");

            return DeserializeObject(json);
        }

        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        private static Models.History DeserializeObject(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(History)}.{nameof(DeserializeObject)}({json})] JSON is null");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<Models.History>(json, JsonHelpers.SerializerSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(History)}.{nameof(DeserializeObject)}({json})] {ex}");
                return null;
            }
        }
    }
}
