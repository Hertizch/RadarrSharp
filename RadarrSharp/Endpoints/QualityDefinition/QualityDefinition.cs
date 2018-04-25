using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.QualityDefinition
{
    /// <summary>
    /// QualityDefinition endpoint client
    /// </summary>
    public class QualityDefinition : IQualityDefinition
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityDefinition"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public QualityDefinition(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all quality definitions
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.QualityDefinition>> GetQualityDefinitions()
        {
            var json = await _radarrClient.ProcessJson("GET", "/qualityDefinition");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.QualityDefinition>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns specific quality definition based on given id
        /// </summary>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> GetQualityDefinition(int id)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/qualityDefinition/id={id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.QualityDefinition>(json, Converter.Settings));
        }

        /// <summary>
        /// Update an existing quality definition
        /// </summary>
        /// <param name="qualityDefinition">QualityDefinition to update - Requires all properties of Models.QualityDefinition object</param>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> UpdateQualityDefinition(Models.QualityDefinition qualityDefinition)
        {
            var json = await _radarrClient.ProcessJson("PUT", "/qualityDefinition", JsonConvert.SerializeObject(qualityDefinition, Converter.Settings));
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.QualityDefinition>(json, Converter.Settings));
        }
    }
}
