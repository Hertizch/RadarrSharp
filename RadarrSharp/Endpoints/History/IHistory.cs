using RadarrSharp.Enums;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    public interface IHistory
    {
        /// <summary>
        /// Gets history (grabs/failures/completed)
        /// </summary>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortKey">Movie title or Date</param>
        /// <param name="sortDirection">Sort direction</param>
        /// <returns>
        /// Models.History
        /// </returns>
        Task<Models.History> GetHistory(int page, [Optional] int pageSize, [Optional] string sortKey, [Optional] SortDirection sortDirection);
    }
}
