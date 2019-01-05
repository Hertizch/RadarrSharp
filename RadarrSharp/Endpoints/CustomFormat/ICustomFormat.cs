using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.CustomFormat
{
    /// <summary>
    /// Custom Formats endpoint client
    /// </summary>
    public interface ICustomFormat
    {
        /// <summary>
        /// Gets the custom formats.
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.CustomFormat>> GetCustomFormats();
    }
}
