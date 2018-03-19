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
        /// <returns>Data.Diskspace[]</returns>
        Task<Data.Diskspace[]> GetDiskspace();
    }
}
