using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.History.IHistory" />
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
            var param = new Dictionary<string, object>
            {
                { "page", page },
                { "pageSize", pageSize },
                { "sortKey", sortKey },
                { "sortDir", sortDir }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/history{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.History>(json, Converter.Settings));
        }
    }
}
