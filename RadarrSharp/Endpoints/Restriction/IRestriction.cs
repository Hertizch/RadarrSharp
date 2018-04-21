using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Restriction
{
    /// <summary>
    /// Restriction endpoint client
    /// </summary>
    public interface IRestriction
    {
        /// <summary>
        /// Returns all configured restrictions (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Restriction>> GetRestrictions();

        /// <summary>
        /// Returns specific restriction based on given id (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        Task<Models.Restriction> GetRestriction(int id);

        /// <summary>
        /// Update an existing restriction
        /// </summary>
        /// <param name="restriction">Restriction to update - Requires all properties of Models.Restriction object</param>
        /// <returns></returns>
        Task<Models.Restriction> UpdateRestriction(Models.Restriction restriction);

        /// <summary>
        /// Add new must contain restriction
        /// </summary>
        /// <param name="required">The required string.</param>
        /// <returns></returns>
        Task<Models.Restriction> AddMustContainRestriction(string required);

        /// <summary>
        /// Add new must not contain restriction
        /// </summary>
        /// <param name="ignored">The ignored string.</param>
        /// <returns></returns>
        Task<Models.Restriction> AddMustNotContainRestriction(string ignored);

        /// <summary>
        /// Delete the restriction with the given ID
        /// </summary>
        /// <param name="id">Restriction ID</param>
        /// <returns></returns>
        Task DeleteRestriction(int id);
    }
}
