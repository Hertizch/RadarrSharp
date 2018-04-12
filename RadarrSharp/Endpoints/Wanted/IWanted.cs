using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Wanted
{
    /// <summary>
    /// Wanted endpoint client
    /// </summary>
    public interface IWanted
    {
        /// <summary>
        /// Returns movies that has not achieved it's cutoff quality
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 100</param>
        /// <returns></returns>
        Task<Models.Wanted> GetCutoffUnmet(int page = 1, int pageSize = 100);

        /// <summary>
        /// Returns movies that has not been downloaded
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 100</param>
        /// <returns></returns>
        Task<Models.Wanted> GetMissing(int page = 1, int pageSize = 100);
    }
}
