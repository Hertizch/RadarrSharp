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
            var json = await _radarrClient.GetJson("/qualityDefinition");
            return JsonConvert.DeserializeObject<IList<Models.QualityDefinition>>(json, Converter.Settings);
        }
    }
}
