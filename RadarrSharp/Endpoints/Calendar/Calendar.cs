using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// Calendar endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Calendar.ICalendar" />
    public class Calendar : ICalendar
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Calendar(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets upcoming movies, if start/end are not supplied movies airing today and tomorrow will be returned
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Calendar>> GetCalendar()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/calendar");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Calendar>>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets upcoming movies, between the given time
        /// </summary>
        /// <param name="start">From date</param>
        /// <param name="end">To date</param>
        /// <returns></returns>
        public async Task<IList<Models.Calendar>> GetCalendar(DateTime start, DateTime end)
        {
            var param = new Dictionary<string, object>
            {
                { "start", start.ToString("yyyy-MM-dd") },
                { "end", end.ToString("yyyy-MM-dd") }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/calendar{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Calendar>>(json, Converter.Settings));
        }
    }
}
