using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        [J("body")] public Body Body { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        [J("priority")] public string Priority { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the queued.
        /// </summary>
        /// <value>
        /// The queued.
        /// </value>
        [J("queued")] public DateTimeOffset Queued { get; set; }

        /// <summary>
        /// Gets or sets the trigger.
        /// </summary>
        /// <value>
        /// The trigger.
        /// </value>
        [J("trigger")] public string Trigger { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [J("state")] public string State { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Command"/> is manual.
        /// </summary>
        /// <value>
        ///   <c>true</c> if manual; otherwise, <c>false</c>.
        /// </value>
        [J("manual")] public bool Manual { get; set; }

        /// <summary>
        /// Gets or sets the started on.
        /// </summary>
        /// <value>
        /// The started on.
        /// </value>
        [J("startedOn")] public DateTimeOffset StartedOn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send updates to client].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send updates to client]; otherwise, <c>false</c>.
        /// </value>
        [J("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [update scheduled task].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [update scheduled task]; otherwise, <c>false</c>.
        /// </value>
        [J("updateScheduledTask")] public bool UpdateScheduledTask { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
