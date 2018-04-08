using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Text;
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
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortKey">Movie title or Date - Default date</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default desc</param>
        /// <returns></returns>
        public async Task<Models.History> GetHistory(int page = 1, int pageSize = 10, string sortKey = "date", string sortDir = "default")
        {
            var sb = new StringBuilder();

            sb.Append($"?page={page}");
            sb.Append($"&pageSize={pageSize}");
            sb.Append($"&sortKey={sortKey}");
            sb.Append($"&sortDir={sortDir}");

            var json = await _radarrClient.GetJson($"/history{sb.ToString()}");

            return JsonConvert.DeserializeObject<Models.History>(json, Converter.Settings);
        }
    }
}
