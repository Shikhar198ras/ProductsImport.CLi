using Newtonsoft.Json;
using ProductsImport.CLi.Utility;
using Xunit;

namespace ProductsImport.Test
{
    public class YamlParserTest
    {
        private readonly YamlParser _parser;
        private readonly MockData _mockData;

        public YamlParserTest()
        {
            _parser = new YamlParser();
            _mockData = new MockData();
        }

        [Fact]
        public void ParseProductsShouldParseProductsByReadingFromYamlFile()
        {
            var mockProducts = JsonConvert.SerializeObject(_mockData.GetYamlMockProducts());
            var actualProducts = JsonConvert.SerializeObject(_parser.ParseProducts("feed-products/capterra.yaml"));
            Assert.Equal(mockProducts, actualProducts);
        }
    }
}
