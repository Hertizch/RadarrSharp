using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.QualityDefinition
{
    /// <summary>
    /// QualityDefinition endpoint client
    /// </summary>
    public interface IQualityDefinition
    {
        /// <summary>
        /// Returns all quality definitions
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.QualityDefinition>> GetQualityDefinitions();
    }
}
