using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.ExtraFile
{
    /// <summary>
    /// ExtraFile endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.ExtraFile.IExtraFile" />
    public class ExtraFile : IExtraFile
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraFile" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public ExtraFile(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the extra files.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns></returns>
        public async Task<IList<Models.ExtraFile>> GetExtraFiles(int movieId)
        {
            var param = new Dictionary<string, object>
            {
                { "movieId", movieId }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/extraFile{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.ExtraFile>>(json, Converter.Settings));
        }
    }
}
