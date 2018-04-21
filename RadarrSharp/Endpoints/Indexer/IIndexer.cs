using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Indexer
{
    /// <summary>
    /// Indexer endpoint client
    /// </summary>
    public interface IIndexer
    {
        /// <summary>
        /// Returns all configured indexers
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Indexer>> GetIndexers();

        /// <summary>
        /// Returns specific indexer based on given id
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<Models.Indexer> GetIndexer(int id);
    }
}
