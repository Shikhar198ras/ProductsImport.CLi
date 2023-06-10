using Newtonsoft.Json;
using ProductsImport.CLi.Utility;
using Xunit;

namespace ProductsImport.Test
{
    public class JsonParserTest
    {
        private readonly JsonParser _parser;
        private readonly MockData _mockData;

        public JsonParserTest()
        {
            _parser = new JsonParser();
            _mockData = new MockData();
        }

        [Fact]
        public void ParseProductsShouldParseProductsByReadingFromJsonFile()
        {
            var mockProducts = JsonConvert.SerializeObject(_mockData.GetMockProducts());
            var actualProducts = JsonConvert.SerializeObject(_parser.ParseProducts("feed-products/softwareadvice.json"));
            Assert.Equal(mockProducts, actualProducts);
        }
    }
}
