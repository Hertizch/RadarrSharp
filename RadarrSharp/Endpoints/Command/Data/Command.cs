using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.Command.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("body")] public Body Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("priority")] public string Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("queued")] public DateTimeOffset Queued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("trigger")] public string Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("state")] public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("manual")] public bool Manual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("startedOn")] public DateTimeOffset StartedOn { get; set; }

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
        [J("id")] public long Id { get; set; }
    }
}
