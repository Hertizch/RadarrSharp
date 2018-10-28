using Newtonsoft.Json;
using RadarrSharp.Enums;
using RadarrSharp.Helpers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Movie
{
    /// <summary>
    /// Movie endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Movie.IMovie" />
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
            var json = await _radarrClient.ProcessJson("GET", "/movie");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Movie>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns all Movies, with pagination, in your collection
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortKey">Sort key, id, title or date - Default id</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default asc</param>
        /// <returns></returns>
        public async Task<Models.MoviePage> GetMoviesPaged(int page = 1, int pageSize = 10, string sortKey = "id", string sortDir = "default")
        {
            var param = new Dictionary<string, object>
            {
                { "page", page },
                { "pageSize", pageSize },
                { "sortKey", sortKey },
                { "sortDir", sortDir }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/movie{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.MoviePage>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns the movie with the matching ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <returns></returns>
        public async Task<Models.Movie> GetMovie(int id)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/movie/id={id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings));
        }

        /// <summary>
        /// Adds a new movie to your collection
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="year">Release year</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="tmdbId">TMDb ID</param>
        /// <param name="rootFolderPath">Root folder path (Full path will be created by combining the rootFolderPath with the movie title)</param>
        /// <param name="minimumAvailability">Minimum availability</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Object that contains one boolean property</param>
        /// <returns></returns>
        public async Task<Models.Movie> AddMovie(string title, int year, int qualityProfileId, string titleSlug, List<Models.Image> images, int tmdbId, string rootFolderPath, MinimumAvailability minimumAvailability, [Optional] bool monitored, [Optional] AddOptions addOptions)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["title"] = title,
                ["year"] = year,
                ["qualityProfileId"] = qualityProfileId,
                ["titleSlug"] = titleSlug,
                ["images"] = images,
                ["tmdbId"] = tmdbId,
                ["rootFolderPath"] = rootFolderPath,
                ["minimumAvailability"] = minimumAvailability.ToString(),
                ["monitored"] = monitored
            };

            if (addOptions != null)
                dictionary.Add("addOptions", addOptions);

            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.ProcessJson("POST", "/movie", parameter);
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings));
        }

        /// <summary>
        /// Update an existing movie
        /// </summary>
        /// <param name="movie">Movie to update - Requires all properties of Models.Movie object</param>
        /// <returns></returns>
        public async Task<Models.Movie> UpdateMovie(Models.Movie movie)
        {
            var json = await _radarrClient.ProcessJson("PUT", "/movie", JsonConvert.SerializeObject(movie, Converter.Settings));
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings));
        }

        /// <summary>
        /// Update multiple existing movies
        /// </summary>
        /// <param name="movies">List of Movies to update - Requires all properties of Models.Movie object</param>
        /// <returns></returns>
        public async Task<IList<Models.Movie>> UpdateMovies(List<Models.Movie> movies)
        {
            var json = await _radarrClient.ProcessJson("PUT", "/movie/editor", JsonConvert.SerializeObject(movies, Converter.Settings));
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Movie>>(json, Converter.Settings));
        }

        /// <summary>
        /// Delete the movie with the given ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="deleteFiles">If true the movie folder and all files will be deleted when the movie is deleted - Default false</param>
        /// <returns></returns>
        public async Task DeleteMovie(int id, [Optional] bool deleteFiles)
        {
            var param = new Dictionary<string, object>
            {
                { "deleteFiles", deleteFiles }
            };

            await _radarrClient.Delete($"/movie/{id}{ParameterHelper.BuildParameterString(param)}");
        }

        /// <summary>
        /// Search for movie by title
        /// </summary>
        /// <param name="title">Search title</param>
        /// <returns></returns>
        public async Task<IList<Models.Movie>> SearchForMovie(string title)
        {
            var param = new Dictionary<string, object>
            {
                { "term", title.Replace(" ", "%20") }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/movie/lookup{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Movie>>(json, Converter.Settings));
        }

        /// <summary>
        /// Search for movie by IMDb ID
        /// </summary>
        /// <param name="imdbId">IMDb ID</param>
        /// <returns></returns>
        public async Task<IList<Models.Movie>> SearchForMovieByImdbId(string imdbId)
        {
            var param = new Dictionary<string, object>
            {
                { "term=imdb:", imdbId }
            };

            var json = await _radarrClient.ProcessJson("GET", $"/movie/lookup{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Movie>>(json, Converter.Settings));
        }

        /// <summary>
        /// Discover new movies
        /// </summary>
        /// <param name="movieDiscoverAction">Movie discover action - Default recommendations</param>
        /// <returns></returns>
        public async Task<IList<Models.Movie>> DiscoverMovies([Optional] MovieDiscoverAction movieDiscoverAction)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/movies/discover{(movieDiscoverAction != 0 ? $"/{movieDiscoverAction.ToString()}" : "")}");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Movie>>(json, Converter.Settings));
        }
    }
}
