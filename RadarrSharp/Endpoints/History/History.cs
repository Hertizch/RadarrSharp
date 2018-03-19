using Newtonsoft.Json;
using RadarrSharp.Enums;
using RadarrSharp.Helpers;
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
        /// Initializes a new instance of the <see cref="History"/> class.
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
        /// <returns>Data.History</returns>
        public async Task<Data.History> GetHistory(int page, [Optional] int pageSize, [Optional] string sortKey, [Optional] SortDirection sortDirection)
        {
            var json = await _radarrClient.GetJson($"/history?page={page}" +
                $"{(pageSize != 0 ? "&pageSize=" + pageSize : "")}" +
                $"{(sortKey != null ? "&sortKey=" + sortKey : "")}" +
                $"{(sortDirection != 0 ? "&sortDir=" + sortDirection.ToString().ToLower() : "")}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.History>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
