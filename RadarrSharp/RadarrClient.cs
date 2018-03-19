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
    /// 
    /// </summary>
    public class RadarrClient
    {
        private WebClient _webClient;

        /// <summary>
        /// Creates the API client to communicate with Radarr service
        /// </summary>
        /// <param name="host">Client hostname or IP address</param>
        /// <param name="port">Client port</param>
        /// <param name="apiKey">Client API key</param>
        /// <param name="urlBase">Url base for reverse proxy support</param>
        /// <param name="useSsl">Communicate with client securely</param>
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
