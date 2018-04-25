using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadarrSharp;
using RadarrSharpUnitTest.Properties;

namespace RadarrSharpUnitTest
{
    [TestClass]
    public class EndpointTest
    {
        private RadarrClient _radarrClient = new RadarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetMovies()
        {
            var obj = await _radarrClient.Movie.GetMovies();
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetMoviesPaged()
        {
            var obj = await _radarrClient.Movie.GetMoviesPaged();
            Assert.IsNotNull(obj);
        }

        /*[TestMethod]
        public async Task AddMovie()
        {
            string title = "Super Troopers 2";
            int year = 2018;
            int qualityProfileId = 1;
            string titleSlug = "super-troopers-2-50022";
            int tmdbId = 50022;
            string rootFolderPath = "/media/";
            MinimumAvailability minimumAvailability = MinimumAvailability.Announced;
            bool monitored = true;

            List<RadarrSharp.Models.Image> images = new List<RadarrSharp.Models.Image>
            {
                new RadarrSharp.Models.Image { CoverType = CoverType.Poster, Url = "https://image.tmdb.org/t/p/original/cgZMf3gKLorz7dDXx2m2sTQQcuy.jpg" },
                new RadarrSharp.Models.Image { CoverType = CoverType.FanArt, Url = "https://image.tmdb.org/t/p/original/v9N8AxyHf9crA9Iza9fF5ntPJFj.jpg" }
            };

            AddOptions addOptions = new AddOptions
            {
                SearchForMovie = true
            };

            var obj = await _radarrClient.Movie.AddMovie(title, year, qualityProfileId, titleSlug, images, tmdbId, rootFolderPath, minimumAvailability, monitored, addOptions);
            Assert.IsNotNull(obj);
        }*/

        /*[TestMethod]
        public async Task UpdateMovie()
        {
            var movie = await _radarrClient.Movie.GetMovie(747);
            movie.Monitored = true;

            var obj = await _radarrClient.Movie.UpdateMovie(movie);
        }*/

        [TestMethod]
        public async Task SearchForMovie()
        {
            var obj = await _radarrClient.Movie.SearchForMovie("terminator");
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task SearchForMovieByImdbId()
        {
            var obj = await _radarrClient.Movie.SearchForMovieByImdbId("tt0859635");
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task DiscoverMovies()
        {
            var obj = await _radarrClient.Movie.DiscoverMovies(RadarrSharp.Endpoints.Movie.MovieDiscoverAction.Popular);
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetCutoffUnmet()
        {
            var obj = await _radarrClient.Wanted.GetCutoffUnmet();
            Assert.IsNotNull(obj);
        }
    }
}
