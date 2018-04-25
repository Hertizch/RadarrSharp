using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Indexer
{
    /// <summary>
    /// Indexer endpoint client
    /// </summary>
    public class Indexer : IIndexer
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Indexer"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Indexer(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all configured indexers
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Indexer>> GetIndexers()
        {
            var json = await _radarrClient.ProcessJson("GET", "/indexer");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Indexer>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns specific indexer based on given id
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Models.Indexer> GetIndexer(int id)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/indexer/id={id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Indexer>(json, Converter.Settings));
        }
    }
}
