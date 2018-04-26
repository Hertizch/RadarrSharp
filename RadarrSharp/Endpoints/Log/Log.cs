using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Log
{
    /// <summary>
    /// Log endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Log.ILog" />
    public class Log : ILog
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Log(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the log files.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.LogFile>> GetLogFiles()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/log/file");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.LogFile>>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public async Task<string> GetLogFile(string filename)
        {
            string logFile = null;

            using (var wc = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(_radarrClient.ApiKey), Proxy = null })
            {
                try
                {
                    logFile = await wc.DownloadStringTaskAsync(_radarrClient.ApiUrl + $"/log/file/filename={filename}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SonarrSharp] [ERROR] [Log.GetLogFile] Filename: '{filename}', {ex}");
                }
            }

            return logFile;
        }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 50</param>
        /// <returns></returns>
        public async Task<Models.Log> GetLog(int page = 1, int pageSize = 50)
        {
            var param = new Dictionary<string, object>
            {
                { "page", page },
                { "pageSize", pageSize }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/log{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Log>(json, Converter.Settings));
        }
    }
}
