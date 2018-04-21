using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Blacklist
{
    /// <summary>
    /// Blacklist endpoint client
    /// </summary>
    public interface IBlacklist
    {
        /// <summary>
        /// Returns all blacklisted items
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <returns></returns>
        Task<Models.Blacklist> GetBlacklist(int page = 1, int pageSize = 10);

        /// <summary>
        /// Delete the blacklisted item with the given ID
        /// </summary>
        /// <param name="id">Blacklist item ID</param>
        /// <returns></returns>
        Task DeleteBlacklist(int id);
    }
}
