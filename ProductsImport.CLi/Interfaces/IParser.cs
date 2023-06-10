using ProductsImport.CLi.Models;
using System.Collections.Generic;

namespace ProductsImport.CLi.Interfaces
{
    public interface IParser
    {
        public IEnumerable<Product> ParseProducts(string path);
    }
}
