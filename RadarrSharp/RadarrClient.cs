using RadarrSharp.Endpoints.Calendar;
using RadarrSharp.Endpoints.Command;
using RadarrSharp.Endpoints.Diskspace;
using RadarrSharp.Endpoints.History;
using RadarrSharp.Endpoints.Movie;
using RadarrSharp.Endpoints.Profile;
using RadarrSharp.Endpoints.SystemStatus;
using RadarrSharp.Endpoints.Wanted;
using RadarrSharp.Helpers;
using System;
using System.Diagnostics;
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
        /// Initializes a new instance of the <see cref="RadarrClient" /> class.
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
            Profile = new Profile(this);
            Wanted = new Wanted(this);
        }

        /// <summary>
        /// Client hostname or IP address
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; private set; }

        /// <summary>
        /// Client port
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port { get; private set; }

        /// <summary>
        /// Client API key
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Url base for reverse proxy support
        /// </summary>
        /// <value>
        /// The URL base.
        /// </value>
        public string UrlBase { get; private set; }

        /// <summary>
        /// Communicate with client securely
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use SSL]; otherwise, <c>false</c>.
        /// </value>
        public bool UseSsl { get; private set; }

        /// <summary>
        /// Client API url
        /// </summary>
        /// <value>
        /// The API URL.
        /// </value>
        internal string ApiUrl { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether [write debug].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [write debug]; otherwise, <c>false</c>.
        /// </value>
        public bool WriteDebug { get; set; }

        /// <summary>
        /// Calendar endpoint client
        /// </summary>
        /// <value>
        /// The calendar.
        /// </value>
        public ICalendar Calendar { get; }

        /// <summary>
        /// Command endpoint client
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public ICommand Command { get; }

        /// <summary>
        /// Diskspace endpoint client
        /// </summary>
        /// <value>
        /// The diskspace.
        /// </value>
        public IDiskspace Diskspace { get; }

        /// <summary>
        /// History endpoint client
        /// </summary>
        /// <value>
        /// The history.
        /// </value>
        public IHistory History { get; }

        /// <summary>
        /// Movie endpoint client
        /// </summary>
        /// <value>
        /// The movie.
        /// </value>
        public IMovie Movie { get; }

        /// <summary>
        /// SystemStatus endpoint client
        /// </summary>
        /// <value>
        /// The system status.
        /// </value>
        public ISystemStatus SystemStatus { get; }

        /// <summary>
        /// Profile endpoint client
        /// </summary>
        /// <value>
        /// The profile.
        /// </value>
        public IProfile Profile { get; }

        /// <summary>
        /// Wanted endpoint client
        /// </summary>
        /// <value>
        /// The wanted.
        /// </value>
        public IWanted Wanted { get; }

        /// <summary>
        /// Gets the GET response as a json formatted string
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <returns>
        /// string
        /// </returns>
        internal async Task<string> GetJson(string endpointUrl)
        {
            if (WriteDebug)
                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.GetJson] Endpoint URL: '{endpointUrl}'");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.DownloadStringTaskAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[RadarrSharp] [ERROR] [RadarrClient.GetJson] Endpoint URL: '{endpointUrl}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.PostJson] Endpoint URL: '{endpointUrl}', response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
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
        /// <returns>
        /// string
        /// </returns>
        internal async Task<string> PostJson(string endpointUrl, string data, string method)
        {
            if (WriteDebug)
                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}'");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.UploadStringTaskAsync($"{ApiUrl}{endpointUrl}", method, data);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[RadarrSharp] [ERROR] [RadarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}', response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
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
        /// <returns>
        /// Nothing
        /// </returns>
        internal async Task Delete(string endpointUrl)
        {
            if (WriteDebug)
                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.Delete] Endpoint URL: '{endpointUrl}'");

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
                    Debug.WriteLine($"[RadarrSharp] [ERROR] [RadarrClient.Delete] Endpoint URL: '{endpointUrl}', {ex}");
                }
            }
        }
    }
}
