using System;
using System.Collections.Generic;

namespace ProductsImport.CLi.Models
{
    public class Product
    {
        public string Title { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public string Twitter { get; set; }
    }

    public class ProductCollection
    {
        public ProductCollection()
        {
            Products = new List<Product>();
        }

        public IEnumerable<Product> Products { get; set; }
    }
}
