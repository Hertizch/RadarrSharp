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
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortKey">Movie title or Date - Default date</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default desc</param>
        /// <returns>
        /// Models.History
        /// </returns>
        Task<Models.History> GetHistory(int page = 1, int pageSize = 10, string sortKey = "date", string sortDir = "default");
    }
}
