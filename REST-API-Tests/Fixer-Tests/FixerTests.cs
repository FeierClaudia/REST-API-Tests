using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fixer_Tests
{
    [TestClass]
    public class FixerTests
    {
        [TestMethod]
        public async Task SymbolsEndpoint_Works()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://data.fixer.io/api/symbols?access_key="+ Constants.FixerApiKey);
            var symbolsResponse = await response.Content.ReadAsAsync<SymbolsResponse>();

            Assert.IsTrue(symbolsResponse.Success);
            Assert.IsTrue(symbolsResponse.Symbols.Count > 0);

        }
    }
}
