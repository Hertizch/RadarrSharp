using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadarrSharp;
using RadarrSharpUnitTest.Properties;

namespace RadarrSharpUnitTest
{
    [TestClass]
    public class IndexerTest
    {
        private RadarrClient _radarrClient = new RadarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetIndexers()
        {
            var obj = await _radarrClient.Indexer.GetIndexers();
            Assert.IsNotNull(obj);
        }
    }
}
