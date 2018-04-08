using Newtonsoft.Json;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Movie
{
    /// <summary>
    /// Movie endpoint client
    /// </summary>
    public class Movie : IMovie
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Movie(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all Movies in your collection
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Movie>> GetMovies()
        {
            var json = await _radarrClient.GetJson("/movie");
            return JsonConvert.DeserializeObject<Models.Movie[]>(json, Converter.Settings);
        }

        /// <summary>
        /// Returns the movie with the matching ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <returns></returns>
        public async Task<Models.Movie> GetMovie(int id)
        {
            var json = await _radarrClient.GetJson($"/movie/id={id}");
            return JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings);
        }

        /// <summary>
        /// Adds a new movie to your collection
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="tmdbId">TMDb ID</param>
        /// <param name="rootFolderPath">Root folder path (Full path will be created by combining the rootFolderPath with the movie title)</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Usage unknown</param>
        /// <returns></returns>
        public async Task<Models.Movie> AddMovie(string title, int qualityProfileId, string titleSlug, Models.Image[] images, int tmdbId, string rootFolderPath, [Optional] bool monitored, [Optional] Dictionary<string, bool> addOptions)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["title"] = title,
                ["qualityProfileId"] = qualityProfileId,
                ["titleSlug"] = titleSlug,
                ["images"] = images,
                ["tmdbId"] = tmdbId,
                ["rootFolderPath"] = rootFolderPath,
                ["monitored"] = monitored
            };

            if (addOptions != null)
                dictionary.Add("addOptions", addOptions);

            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.PostJson("/movie", parameter, "POST");
            return JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings);
        }

        /// <summary>
        /// Update an existing movie
        /// </summary>
        /// <param name="movie">Movie to update - Requires all properties of Models.Movie object</param>
        /// <returns></returns>
        public async Task<Models.Movie> UpdateMovie(Models.Movie movie)
        {
            var json = await _radarrClient.PostJson("/movie", JsonConvert.SerializeObject(movie), "PUT");
            return JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings);
        }

        /// <summary>
        /// Delete the movie with the given ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="deleteFiles">If true the movie folder and all files will be deleted when the movie is deleted</param>
        /// <returns></returns>
        public async Task DeleteMovie(int id, [Optional] bool deleteFiles)
        {
            await _radarrClient.Delete($"/movie/id={id}{(deleteFiles ? $"?deleteFiles={deleteFiles}" : "")}");
        }
    }
}
