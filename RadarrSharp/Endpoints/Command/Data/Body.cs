using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.Command.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Body
    {
        /// <summary>
        /// 
        /// </summary>
        [J("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("updateScheduledTask")] public bool UpdateScheduledTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("completionMessage")] public string CompletionMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("trigger")] public string Trigger { get; set; }
    }
}
