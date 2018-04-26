using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.ExtraFile
{
    /// <summary>
    /// ExtraFile endpoint client
    /// </summary>
    public interface IExtraFile
    {
        /// <summary>
        /// Gets the extra files.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns></returns>
        Task<IList<Models.ExtraFile>> GetExtraFiles(int movieId);
    }
}
