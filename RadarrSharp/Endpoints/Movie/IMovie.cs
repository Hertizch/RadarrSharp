using RadarrSharp.Enums;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Movie
{
    /// <summary>
    /// Movie endpoint client
    /// </summary>
    public interface IMovie
    {
        /// <summary>
        /// Returns all Movies in your collection
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Movie>> GetMovies();

        /// <summary>
        /// Returns all Movies, with pagination, in your collection
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortKey">Sort key, id, title or date - Default id</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default asc</param>
        /// <returns></returns>
        Task<Models.MoviePage> GetMoviesPaged(int page = 1, int pageSize = 10, string sortKey = "id", string sortDir = "default");

        /// <summary>
        /// Returns the movie with the matching ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <returns></returns>
        Task<Models.Movie> GetMovie(int id);

        /// <summary>
        /// Adds a new movie to your collection
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="year">Release year</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="tmdbId">TMDb ID</param>
        /// <param name="rootFolderPath">Full path will be created by combining the rootFolderPath with the movie title</param>
        /// <param name="minimumAvailability">Minimum availability</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Object that contains one boolean property</param>
        /// <returns></returns>
        Task<Models.Movie> AddMovie(string title, int year, int qualityProfileId, string titleSlug, List<Models.Image> images, int tmdbId, string rootFolderPath, MinimumAvailability minimumAvailability, [Optional] bool monitored, [Optional] AddOptions addOptions);

        /// <summary>
        /// Update an existing movie
        /// </summary>
        /// <param name="movie">Movie to update - Requires all properties of Models.Movie object</param>
        /// <returns></returns>
        Task<Models.Movie> UpdateMovie(Models.Movie movie);

        /// <summary>
        /// Update multiple existing movies
        /// </summary>
        /// <param name="movies">List of Movies to update - Requires all properties of Models.Movie object</param>
        /// <returns></returns>
        Task<IList<Models.Movie>> UpdateMovies(List<Models.Movie> movies);

        /// <summary>
        /// Delete the movie with the given ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="deleteFiles">If true the movie folder and all files will be deleted when the movie is deleted</param>
        /// <returns></returns>
        Task DeleteMovie(int id, [Optional] bool deleteFiles);

        /// <summary>
        /// Search for movie by title
        /// </summary>
        /// <param name="title">Search title</param>
        /// <returns></returns>
        Task<IList<Models.Movie>> SearchForMovie(string title);

        /// <summary>
        /// Search for movie by IMDb ID
        /// </summary>
        /// <param name="imdbId">IMDb ID</param>
        /// <returns></returns>
        Task<IList<Models.Movie>> SearchForMovieByImdbId(string imdbId);

        /// <summary>
        /// Discover new movies
        /// </summary>
        /// <param name="movieDiscoverAction">Movie discover action - Default recommendations</param>
        /// <returns></returns>
        Task<IList<Models.Movie>> DiscoverMovies([Optional] MovieDiscoverAction movieDiscoverAction);
    }
}
