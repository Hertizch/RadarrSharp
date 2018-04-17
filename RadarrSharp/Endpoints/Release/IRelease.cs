using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Release
{
    /// <summary>
    /// Release endpoint client
    /// </summary>
    public interface IRelease
    {
        /// <summary>
        /// Gets releases from Radarr's search cache (30 minute cache)
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Release>> GetReleases();

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Radarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns></returns>
        Task<IList<Models.Release>> AddRelease(string guid);
    }
}
