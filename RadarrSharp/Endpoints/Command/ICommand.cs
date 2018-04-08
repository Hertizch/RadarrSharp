using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Command
{
    /// <summary>
    /// Command endpoint client
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Queries the status of all currently started commands.
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Command>> GetCommands();

        /// <summary>
        /// Queries the status of a previously started command
        /// </summary>
        /// <param name="id">Unique ID of the command</param>
        /// <returns></returns>
        Task<Models.Command> GetCommand(int id);

        /// <summary>
        /// Refresh movie information from TMDb and rescan disk
        /// </summary>
        /// <param name="movieId">Movie ID</param>
        /// <returns></returns>
        Task<Models.Command> RefreshMovie([Optional] int movieId);

        /// <summary>
        /// Rescan disk for single movie. If movieId not set all movies will be scanned
        /// </summary>
        /// <param name="movieId">Movie ID</param>
        /// <returns></returns>
        Task<Models.Command> RescanMovie([Optional] int movieId);

        /// <summary>
        /// Search for one or more movies
        /// </summary>
        /// <param name="movieIds">Movie ID's</param>
        /// <returns></returns>
        Task<Models.Command> MoviesSearch(int[] movieIds);

        /// <summary>
        /// Instruct Radarr to perform an RSS sync with all enabled indexers
        /// </summary>
        /// <returns></returns>
        Task<Models.Command> RssSync();

        /// <summary>
        /// Instruct Radarr to rename the list of files provided.
        /// </summary>
        /// <param name="files">List of File ID's to rename</param>
        /// <returns></returns>
        Task<Models.Command> RenameFiles(int[] files);

        /// <summary>
        /// Instruct Radarr to rename all files in the provided movies.
        /// </summary>
        /// <param name="movieIds">List of Movie ID's to rename</param>
        /// <returns></returns>
        Task<Models.Command> RenameMovies(int[] movieIds);

        /// <summary>
        /// Instructs Radarr to search all cutoff unmet movies (Take care, since it could go over your indexers api limits!)
        /// </summary>
        /// <param name="filterKey">Key by which to further filter cutoff unmet movies. (Possible values: monitored (recommended), all, status)</param>
        /// <param name="filterValue">Value by which to further filter cutoff unmet movies. This must correspond to the filterKey. (Possible values with respect to the ones for the filterKey above: (true (recommended), false), (all), (available, released, inCinemas, announced)</param>
        /// <returns></returns>
        Task<Models.Command> CutOffUnmetMoviesSearch(string filterKey, string filterValue);

        /// <summary>
        /// Instructs Radarr to search all lists for movies not yet added to Radarr.
        /// </summary>
        /// <returns></returns>
        Task<Models.Command> NetImportSync();

        /// <summary>
        /// Instructs Radarr to search all missing movies. This functionality is similar to what CouchPotato does and runs a backlog search for all your missing movies. For example You can use this api with curl and crontab to instruct Radarr to run a backlog search on 1 AM everyday.
        /// </summary>
        /// <param name="filterKey">Key by which to further filter missing movies. (Possible values: monitored (recommended), all, status)</param>
        /// <param name="filterValue">Value by which to further filter missing movies. This must correspond to the filterKey. (Possible values with respect to the ones for the filterKey above: (true (recommended), false), (all), (available, released, inCinemas, announced)</param>
        /// <returns></returns>
        Task<Models.Command> MissingMoviesSearch(string filterKey, string filterValue);
    }
}
