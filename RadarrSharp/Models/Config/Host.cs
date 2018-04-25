using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// Gets or sets the bind address.
        /// </summary>
        /// <value>
        /// The bind address.
        /// </value>
        [J("bindAddress")] public string BindAddress { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        [J("port")] public long Port { get; set; }

        /// <summary>
        /// Gets or sets the SSL port.
        /// </summary>
        /// <value>
        /// The SSL port.
        /// </value>
        [J("sslPort")] public long SslPort { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable SSL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable SSL]; otherwise, <c>false</c>.
        /// </value>
        [J("enableSsl")] public bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [launch browser].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [launch browser]; otherwise, <c>false</c>.
        /// </value>
        [J("launchBrowser")] public bool LaunchBrowser { get; set; }

        /// <summary>
        /// Gets or sets the authentication method.
        /// </summary>
        /// <value>
        /// The authentication method.
        /// </value>
        [J("authenticationMethod")] public string AuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [analytics enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [analytics enabled]; otherwise, <c>false</c>.
        /// </value>
        [J("analyticsEnabled")] public bool AnalyticsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the log level.
        /// </summary>
        /// <value>
        /// The log level.
        /// </value>
        [J("logLevel")] public string LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the branch.
        /// </summary>
        /// <value>
        /// The branch.
        /// </value>
        [J("branch")] public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        [J("apiKey")] public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the SSL cert hash.
        /// </summary>
        /// <value>
        /// The SSL cert hash.
        /// </value>
        [J("sslCertHash")] public string SslCertHash { get; set; }

        /// <summary>
        /// Gets or sets the URL base.
        /// </summary>
        /// <value>
        /// The URL base.
        /// </value>
        [J("urlBase")] public string UrlBase { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [update automatically].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [update automatically]; otherwise, <c>false</c>.
        /// </value>
        [J("updateAutomatically")] public bool UpdateAutomatically { get; set; }

        /// <summary>
        /// Gets or sets the update mechanism.
        /// </summary>
        /// <value>
        /// The update mechanism.
        /// </value>
        [J("updateMechanism")] public string UpdateMechanism { get; set; }

        /// <summary>
        /// Gets or sets the update script path.
        /// </summary>
        /// <value>
        /// The update script path.
        /// </value>
        [J("updateScriptPath")] public string UpdateScriptPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [proxy enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [proxy enabled]; otherwise, <c>false</c>.
        /// </value>
        [J("proxyEnabled")] public bool ProxyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the type of the proxy.
        /// </summary>
        /// <value>
        /// The type of the proxy.
        /// </value>
        [J("proxyType")] public string ProxyType { get; set; }

        /// <summary>
        /// Gets or sets the proxy hostname.
        /// </summary>
        /// <value>
        /// The proxy hostname.
        /// </value>
        [J("proxyHostname")] public string ProxyHostname { get; set; }

        /// <summary>
        /// Gets or sets the proxy port.
        /// </summary>
        /// <value>
        /// The proxy port.
        /// </value>
        [J("proxyPort")] public long ProxyPort { get; set; }

        /// <summary>
        /// Gets or sets the proxy username.
        /// </summary>
        /// <value>
        /// The proxy username.
        /// </value>
        [J("proxyUsername")] public string ProxyUsername { get; set; }

        /// <summary>
        /// Gets or sets the proxy password.
        /// </summary>
        /// <value>
        /// The proxy password.
        /// </value>
        [J("proxyPassword")] public string ProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets the proxy bypass filter.
        /// </summary>
        /// <value>
        /// The proxy bypass filter.
        /// </value>
        [J("proxyBypassFilter")] public string ProxyBypassFilter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [proxy bypass local addresses].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [proxy bypass local addresses]; otherwise, <c>false</c>.
        /// </value>
        [J("proxyBypassLocalAddresses")] public bool ProxyBypassLocalAddresses { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
