using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Blacklist
{
    /// <summary>
    /// Blacklist endpoint client
    /// </summary>
    public class Blacklist : IBlacklist
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Blacklist"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Blacklist(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all blacklisted items
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <returns></returns>
        public async Task<Models.Blacklist> GetBlacklist(int page = 1, int pageSize = 10)
        {
            var json = await _radarrClient.GetJson($"/blacklist?page={page}&pageSize={pageSize}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Blacklist>(json, Converter.Settings));
        }

        /// <summary>
        /// Delete the blacklisted item with the given ID
        /// </summary>
        /// <param name="id">Blacklist item ID</param>
        /// <returns></returns>
        public async Task DeleteBlacklist(int id)
        {
            await _radarrClient.Delete($"/blacklist/id={id}");
        }
    }
}
