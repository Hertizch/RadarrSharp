using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// Diskspace endpoint client
    /// </summary>
    public interface IDiskspace
    {
        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Diskspace>> GetDiskspace();
    }
}
