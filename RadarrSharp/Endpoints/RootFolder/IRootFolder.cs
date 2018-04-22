using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.RootFolder
{
    /// <summary>
    /// RootFolder endpoint client
    /// </summary>
    public interface IRootFolder
    {
        /// <summary>
        /// Gets the root folders.
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.RootFolder>> GetRootFolders();
    }
}
