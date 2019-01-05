using RadarrSharp.Endpoints.Blacklist;
using RadarrSharp.Endpoints.Calendar;
using RadarrSharp.Endpoints.Command;
using RadarrSharp.Endpoints.Config;
using RadarrSharp.Endpoints.CustomFormat;
using RadarrSharp.Endpoints.Diskspace;
using RadarrSharp.Endpoints.ExtraFile;
using RadarrSharp.Endpoints.History;
using RadarrSharp.Endpoints.Indexer;
using RadarrSharp.Endpoints.Log;
using RadarrSharp.Endpoints.Movie;
using RadarrSharp.Endpoints.Notification;
using RadarrSharp.Endpoints.Profile;
using RadarrSharp.Endpoints.QualityDefinition;
using RadarrSharp.Endpoints.Queue;
using RadarrSharp.Endpoints.Release;
using RadarrSharp.Endpoints.Restriction;
using RadarrSharp.Endpoints.RootFolder;
using RadarrSharp.Endpoints.SystemStatus;
using RadarrSharp.Endpoints.Wanted;
using RadarrSharp.Helpers;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
            var sb = new StringBuilder();
            sb.Append("http");
            if (UseSsl) sb.Append("s");
            sb.Append($"://{host}:{Port}");
            if (UrlBase != null) sb.Append($"/{UrlBase}");
            sb.Append("/api");
            ApiUrl = sb.ToString();

            // Initialize endpoints
            Calendar = new Calendar(this);
            Command = new Command(this);
            Diskspace = new Diskspace(this);
            History = new History(this);
            Movie = new Movie(this);
            SystemStatus = new SystemStatus(this);
            Profile = new Profile(this);
            Wanted = new Wanted(this);
            Log = new Log(this);
            Queue = new Queue(this);
            Release = new Release(this);
            QualityDefinition = new QualityDefinition(this);
            Indexer = new Indexer(this);
            Restriction = new Restriction(this);
            Blacklist = new Blacklist(this);
            Notification = new Notification(this);
            RootFolder = new RootFolder(this);
            Config = new Config(this);
            ExtraFile = new ExtraFile(this);
            CustomFormat = new CustomFormat(this);
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
        public string ApiUrl { get; private set; }

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
        /// Log endpoint client
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        public ILog Log { get; }

        /// <summary>
        /// Queue endpoint client
        /// </summary>
        /// <value>
        /// The queue.
        /// </value>
        public IQueue Queue { get; }

        /// <summary>
        /// Release endpoint client
        /// </summary>
        /// <value>
        /// The release.
        /// </value>
        public IRelease Release { get; }

        /// <summary>
        /// QualityDefinition endpoint client
        /// </summary>
        /// <value>
        /// The quality definition.
        /// </value>
        public IQualityDefinition QualityDefinition { get; }

        /// <summary>
        /// Indexer endpoint client
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        public IIndexer Indexer { get; }

        /// <summary>
        /// Restriction endpoint client
        /// </summary>
        /// <value>
        /// The restriction.
        /// </value>
        public IRestriction Restriction { get; }

        /// <summary>
        /// Blacklist endpoint client
        /// </summary>
        /// <value>
        /// The blacklist.
        /// </value>
        public IBlacklist Blacklist { get; }

        /// <summary>
        /// Notification endpoint client
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        public INotification Notification { get; }

        /// <summary>
        /// RootFolder endpoint client
        /// </summary>
        /// <value>
        /// The root folder.
        /// </value>
        public IRootFolder RootFolder { get; }

        /// <summary>
        /// Config endpoint client
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfig Config { get; set; }

        /// <summary>
        /// ExtraFile endpoint client
        /// </summary>
        /// <value>
        /// The extra file.
        /// </value>
        public IExtraFile ExtraFile { get; }

        /// <summary>
        /// Gets the custom format.
        /// </summary>
        /// <value>
        /// The custom format.
        /// </value>
        public ICustomFormat CustomFormat { get; }

        /// <summary>
        /// Processes the json.
        /// </summary>
        /// <param name="method">HTTP method, GET, POST or PUT</param>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <param name="data">Json formatted string</param>
        /// <returns></returns>
        internal async Task<string> ProcessJson(string method, string endpointUrl, [Optional] string data)
        {
            if (WriteDebug)
                Debug.WriteLine($"[RadarrSharp] [ProcessJson] [DEBUG] '{method}': Endpoint URL: '{endpointUrl}', data: '{data}'");

            string response = null;

            using (_webClient = new WebClient
            {
                Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey),
                Proxy = null,
                Encoding = Encoding.UTF8
            })
            {
                try
                {
                    if (method == "POST" || method == "PUT")
                        response = await _webClient.UploadStringTaskAsync($"{ApiUrl}{endpointUrl}", method, data);

                    if (method == "GET")
                        response = await _webClient.DownloadStringTaskAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[RadarrSharp] [ProcessJson] [ERROR] '{method}': Endpoint URL: '{endpointUrl}', data: '{data}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[RadarrSharp] [ProcessJson] [DEBUG] Response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[RadarrSharp] [ProcessJson] [DEBUG] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

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
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}");

                try
                {
                    await httpClient.DeleteAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[RadarrSharp] [ERROR] [RadarrClient.Delete] Endpoint URL: '{endpointUrl}', {ex}");
                }
            }
        }
    }
}
