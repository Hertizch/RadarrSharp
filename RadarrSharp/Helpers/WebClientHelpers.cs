using System.Net;
using System.Reflection;

namespace RadarrSharp.Helpers
{
    internal class WebClientHelpers
    {
        /// <summary>
        /// Gets the response header values to supply with any requests made to the Radarr API service
        /// </summary>
        /// <returns>WebHeaderCollection</returns>
        internal static WebHeaderCollection GetWebHeaderCollection(string apiKey)
        {
            return new WebHeaderCollection
            {
                { "X-Api-Key", apiKey },
                { "Content-Type", "application/json" },
                { "User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}" }
            };
        }
    }
}

//wc.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");