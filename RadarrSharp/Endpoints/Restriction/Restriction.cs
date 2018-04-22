using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Restriction
{
    /// <summary>
    /// Restriction endpoint client
    /// </summary>
    public class Restriction : IRestriction
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Restriction(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all configured restrictions (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Restriction>> GetRestrictions()
        {
            var json = await _radarrClient.GetJson("/restriction");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Restriction>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns specific restriction based on given id (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Restriction> GetRestriction(int id)
        {
            var json = await _radarrClient.GetJson($"/restriction/id={id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Restriction>(json, Converter.Settings));
        }

        /// <summary>
        /// Update an existing restriction
        /// </summary>
        /// <param name="restriction">Restriction to update - Requires all properties of Models.Restriction object</param>
        /// <returns></returns>
        public async Task<Models.Restriction> UpdateRestriction(Models.Restriction restriction)
        {
            var json = await _radarrClient.PostJson("/restriction", JsonConvert.SerializeObject(restriction, Converter.Settings), "PUT");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Restriction>(json, Converter.Settings));
        }

        /// <summary>
        /// Add new must contain restriction
        /// </summary>
        /// <param name="required">The required string.</param>
        /// <returns></returns>
        public async Task<Models.Restriction> AddMustContainRestriction(string required)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["required"] = required
            };

            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.PostJson("/restriction", parameter, "POST");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Restriction>(json, Converter.Settings));
        }

        /// <summary>
        /// Add new must not contain restriction
        /// </summary>
        /// <param name="ignored">The ignored string.</param>
        /// <returns></returns>
        public async Task<Models.Restriction> AddMustNotContainRestriction(string ignored)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["ignored"] = ignored
            };

            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.PostJson("/restriction", parameter, "POST");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Restriction>(json, Converter.Settings));
        }

        /// <summary>
        /// Delete the restriction with the given ID
        /// </summary>
        /// <param name="id">Restriction ID</param>
        /// <returns></returns>
        public async Task DeleteRestriction(int id)
        {
            await _radarrClient.Delete($"/restriction/id={id}");
        }
    }
}
