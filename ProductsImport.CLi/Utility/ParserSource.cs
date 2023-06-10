using ProductsImport.CLi.Interfaces;

namespace ProductsImport.CLi.Utility
{
    public class ParserSource
    {
        public IParser GetParser(string parserName)
        {
            switch (parserName)
            {
                case "yaml":
                    return new YamlParser();
                case "json":
                    return new JsonParser();
            }
            return null;
        }
    }
}
