using RadarrSharp.Endpoints.Calendar;
using RadarrSharp.Endpoints.Command;
using RadarrSharp.Endpoints.Diskspace;
using RadarrSharp.Endpoints.History;
using RadarrSharp.Endpoints.Movie;
using RadarrSharp.Endpoints.SystemStatus;
using RadarrSharp.Helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RadarrSharp
{
    /// <summary>
    /// RadarrClient
    /// </summary>
    public class RadarrClient
    {
        private WebClient _webClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadarrClient"/> class.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <param name="port">The port.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="urlBase">The URL base.</param>
        /// <param name="useSsl">if set to <c>true</c> [use SSL].</param>
        public RadarrClient(string host, int port, string apiKey, [Optional] string urlBase, [Optional] bool useSsl)
        {
            // Initialize properties
            Host = host;
            Port = port;
            ApiKey = apiKey;
            UrlBase = urlBase;
            UseSsl = useSsl;

            // Set API URL
            ApiUrl = $"http{(UseSsl ? "s" : "")}://{Host}:{Port}{("/" + UrlBase ?? "")}/api";

            // Initialize endpoints
            Calendar = new Calendar(this);
            Command = new Command(this);
            Diskspace = new Diskspace(this);
            History = new History(this);
            Movie = new Movie(this);
            SystemStatus = new SystemStatus(this);
        }

        /// <summary>
        /// Client hostname or IP address
        /// </summary>
        public string Host { get; private set; }

        /// <summary>
        /// Client port
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Client API key
        /// </summary>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Url base for reverse proxy support
        /// </summary>
        public string UrlBase { get; private set; }

        /// <summary>
        /// Communicate with client securely
        /// </summary>
        public bool UseSsl { get; private set; }

        /// <summary>
        /// Client API url
        /// </summary>
        internal string ApiUrl { get; private set; }

        /// <summary>
        /// (NOT YET USED) Write log information to file - defaults to false
        /// </summary>
        public bool WriteLogToFile { get; set; }

        /// <summary>
        /// Log filename - defaults to radarrSharp.log in executing assembly path
        /// </summary>
        public string LogFilename { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "radarrSharp.log");

        /// <summary>
        /// Verbose logging - should only be used for debugging
        /// </summary>
        public bool VerboseLogging { get; set; }

        /// <summary>
        /// Calendar endpoint client
        /// </summary>
        public ICalendar Calendar { get; }

        /// <summary>
        /// Command endpoint client
        /// </summary>
        public ICommand Command { get; }

        /// <summary>
        /// Diskspace endpoint client
        /// </summary>
        public IDiskspace Diskspace { get; }

        /// <summary>
        /// History endpoint client
        /// </summary>
        public IHistory History { get; }

        /// <summary>
        /// Movie endpoint client
        /// </summary>
        public IMovie Movie { get; }

        /// <summary>
        /// SystemStatus endpoint client
        /// </summary>
        public ISystemStatus SystemStatus { get; }

        /// <summary>
        /// Gets the GET response as a json formatted string
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <returns>string</returns>
        internal async Task<string> GetJson(string endpointUrl)
        {
            Debug.WriteLine($"[{DateTime.Now}] [INFO] [RadarrClient.GetJson] {ApiUrl}{endpointUrl}");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.DownloadStringTaskAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[{DateTime.Now}] [ERROR] [RadarrClient.GetJson] {ex}");
                }
                finally
                {
                    if (VerboseLogging)
                    {
                        Debug.WriteLine($"[{DateTime.Now}] [DEBUG] [RadarrClient.GetJson] Response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[{DateTime.Now}] [DEBUG] [RadarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

            if (!string.IsNullOrEmpty(response)) // Convert response to UTF8
                response = Encoding.UTF8.GetString(Encoding.Default.GetBytes(response));

            return response;
        }

        /// <summary>
        /// Gets the POST/PUT response as a json formatted string
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <param name="data">Json formatted string</param>
        /// <param name="method">HTTP method, POST/PUT</param>
        /// <returns>string</returns>
        internal async Task<string> PostJson(string endpointUrl, string data, string method)
        {
            Debug.WriteLine($"[{DateTime.Now}] [INFO] [RadarrClient.PostJson] {ApiUrl}{endpointUrl} - Data: {data}");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.UploadStringTaskAsync($"{ApiUrl}{endpointUrl}", method, data);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[{DateTime.Now}] [ERROR] [RadarrClient.PostJson] {ex}");
                }
                finally
                {
                    if (VerboseLogging)
                    {
                        Debug.WriteLine($"[{DateTime.Now}] [DEBUG] [RadarrClient.PostJson] Response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[{DateTime.Now}] [INFO] [RadarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

            if (!string.IsNullOrEmpty(response)) // Convert response to UTF8
                response = Encoding.UTF8.GetString(Encoding.Default.GetBytes(response));

            return response;
        }

        /// <summary>
        /// Send DELETE request to specified url
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <returns>Nothing</returns>
        internal async Task Delete(string endpointUrl)
        {
            Debug.WriteLine($"[{DateTime.Now}] [INFO] [RadarrClient.Delete] {ApiUrl}{endpointUrl}");

            using (var httpClient = new HttpClient { BaseAddress = new Uri(ApiUrl) })
            {
                httpClient.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
                httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add("User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}");

                try
                {
                    await httpClient.DeleteAsync(endpointUrl);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[{DateTime.Now}] [ERROR] [RadarrClient.Delete] {ex}");
                }
            }
        }
    }
}
