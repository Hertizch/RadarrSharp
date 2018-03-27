using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Command
{
    /// <summary>
    /// Command endpoint client
    /// </summary>
    public class Command : ICommand
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Command" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Command(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Queries the status of all currently started commands.
        /// </summary>
        /// <returns>
        /// Models.Command[]
        /// </returns>
        public async Task<Models.Command[]> GetCommands()
        {
            var json = await _radarrClient.GetJson($"/command");
            return DeserializeArray(json);
        }

        /// <summary>
        /// Queries the status of a previously started command
        /// </summary>
        /// <param name="id">Unique ID of the command</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> GetCommand(int id)
        {
            var json = await _radarrClient.GetJson($"/command/{id}");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Refresh movie information from TMDb and rescan disk
        /// </summary>
        /// <param name="movieId">Movie ID</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> RefreshMovie([Optional] int movieId)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "refreshMovie",
                ["movieId "] = movieId
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Rescan disk for single movie. If movieId not set all movies will be scanned
        /// </summary>
        /// <param name="movieId">Movie ID</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> RescanMovie([Optional] int movieId)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "rescanMovie",
                ["movieId"] = movieId
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Search for one or more movies
        /// </summary>
        /// <param name="movieIds">Movie ID's</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> MoviesSearch(int[] movieIds)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "moviesSearch",
                ["movieIds "] = movieIds
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instruct Radarr to perform an RSS sync with all enabled indexers
        /// </summary>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> RssSync()
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "rssSync"
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instruct Radarr to rename the list of files provided.
        /// </summary>
        /// <param name="files">List of File ID's to rename</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> RenameFiles(int[] files)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "renameFiles",
                ["files"] = files
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instruct Radarr to rename all files in the provided movies.
        /// </summary>
        /// <param name="movieIds">List of Movie ID's to rename</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> RenameMovies(int[] movieIds)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "renameMovies",
                ["movieIds "] = movieIds
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instructs Radarr to search all cutoff unmet movies (Take care, since it could go over your indexers api limits!)
        /// </summary>
        /// <param name="filterKey">Key by which to further filter cutoff unmet movies. (Possible values: monitored (recommended), all, status)</param>
        /// <param name="filterValue">Value by which to further filter cutoff unmet movies. This must correspond to the filterKey. (Possible values with respect to the ones for the filterKey above: (true (recommended), false), (all), (available, released, inCinemas, announced)</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> CutOffUnmetMoviesSearch(string filterKey, string filterValue)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "cutOffUnmetMoviesSearch",
                ["filterKey"] = filterKey,
                ["filterValue"] = filterValue
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instructs Radarr to search all lists for movies not yet added to Radarr.
        /// </summary>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> NetImportSync()
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "netImportSync"
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Instructs Radarr to search all missing movies. This functionality is similar to what CouchPotato does and runs a backlog search for all your missing movies. For example You can use this api with curl and crontab to instruct Radarr to run a backlog search on 1 AM everyday.
        /// </summary>
        /// <param name="filterKey">Key by which to further filter missing movies. (Possible values: monitored (recommended), all, status)</param>
        /// <param name="filterValue">Value by which to further filter missing movies. This must correspond to the filterKey. (Possible values with respect to the ones for the filterKey above: (true (recommended), false), (all), (available, released, inCinemas, announced)</param>
        /// <returns>
        /// Models.Command
        /// </returns>
        public async Task<Models.Command> MissingMoviesSearch(string filterKey, string filterValue)
        {
            var parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "missingMoviesSearch",
                ["filterKey"] = filterKey,
                ["filterValue"] = filterValue
            });

            var json = await _radarrClient.PostJson("/command", parameter, "POST");
            return DeserializeObject(json);
        }

        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        private static Models.Command DeserializeObject(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Command)}.{nameof(DeserializeObject)}({json})] JSON is null");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<Models.Command>(json, JsonHelpers.SerializerSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Command)}.{nameof(DeserializeObject)}({json})] {ex}");
                return null;
            }
        }

        /// <summary>
        /// Deserializes the array.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        private static Models.Command[] DeserializeArray(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Command)}.{nameof(DeserializeArray)}({json})] JSON is null");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<Models.Command[]>(json, JsonHelpers.SerializerSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[{DateTime.Now}] [ERROR] [{nameof(Command)}.{nameof(DeserializeArray)}({json})] {ex}");
                return null;
            }
        }
    }
}
