using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Notification
{
    /// <summary>
    /// Notification endpoint client
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Returns all configured notification agents
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Notification>> GetNotificationAgents();
    }
}
