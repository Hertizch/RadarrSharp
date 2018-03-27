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
        /// <returns>
        /// Models.Movie[]
        /// </returns>
        Task<Models.Movie[]> GetMovies();

        /// <summary>
        /// Returns the movie with the matching ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <returns>
        /// Models.Movie
        /// </returns>
        Task<Models.Movie> GetMovie(int id);

        /// <summary>
        /// Adds a new movie to your collection
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="tmdbId">TMDb ID</param>
        /// <param name="rootFolderPath">Full path will be created by combining the rootFolderPath with the movie title</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Usage unknown</param>
        /// <returns>
        /// Models.Movie
        /// </returns>
        Task<Models.Movie> AddMovie(string title, int qualityProfileId, string titleSlug, Models.Image[] images, int tmdbId, string rootFolderPath, [Optional] bool monitored, [Optional] Dictionary<string, bool> addOptions);

        /// <summary>
        /// Update an existing movie
        /// </summary>
        /// <param name="movie">Movie to update - Requires all properties of Data.Movie object</param>
        /// <returns>
        /// Models.Movie
        /// </returns>
        Task<Models.Movie> UpdateMovie(Models.Movie movie);

        /// <summary>
        /// Delete the movie with the given ID
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="deleteFiles">If true the movie folder and all files will be deleted when the movie is deleted</param>
        /// <returns>
        /// Nothing
        /// </returns>
        Task DeleteMovie(int id, [Optional] bool deleteFiles);
    }
}
