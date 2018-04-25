using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Indexer
    {
        /// <summary>
        /// Gets or sets the minimum age.
        /// </summary>
        /// <value>
        /// The minimum age.
        /// </value>
        [J("minimumAge")] public long MinimumAge { get; set; }

        /// <summary>
        /// Gets or sets the maximum size.
        /// </summary>
        /// <value>
        /// The maximum size.
        /// </value>
        [J("maximumSize")] public long MaximumSize { get; set; }

        /// <summary>
        /// Gets or sets the retention.
        /// </summary>
        /// <value>
        /// The retention.
        /// </value>
        [J("retention")] public long Retention { get; set; }

        /// <summary>
        /// Gets or sets the RSS synchronize interval.
        /// </summary>
        /// <value>
        /// The RSS synchronize interval.
        /// </value>
        [J("rssSyncInterval")] public long RssSyncInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [prefer indexer flags].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [prefer indexer flags]; otherwise, <c>false</c>.
        /// </value>
        [J("preferIndexerFlags")] public bool PreferIndexerFlags { get; set; }

        /// <summary>
        /// Gets or sets the availability delay.
        /// </summary>
        /// <value>
        /// The availability delay.
        /// </value>
        [J("availabilityDelay")] public long AvailabilityDelay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow hardcoded subs].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow hardcoded subs]; otherwise, <c>false</c>.
        /// </value>
        [J("allowHardcodedSubs")] public bool AllowHardcodedSubs { get; set; }

        /// <summary>
        /// Gets or sets the whitelisted hardcoded subs.
        /// </summary>
        /// <value>
        /// The whitelisted hardcoded subs.
        /// </value>
        [J("whitelistedHardcodedSubs")] public string WhitelistedHardcodedSubs { get; set; }

        /// <summary>
        /// Gets or sets the parsing leniency.
        /// </summary>
        /// <value>
        /// The parsing leniency.
        /// </value>
        [J("parsingLeniency")] public string ParsingLeniency { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
