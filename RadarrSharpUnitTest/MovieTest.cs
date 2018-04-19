using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadarrSharp;
using RadarrSharpUnitTest.Properties;

namespace RadarrSharpUnitTest
{
    [TestClass]
    public class MovieTest
    {
        private RadarrClient _radarrClient = new RadarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetMovie()
        {
            var obj = await _radarrClient.Movie.GetMovies();
            Assert.IsNotNull(obj);
        }
    }
}
