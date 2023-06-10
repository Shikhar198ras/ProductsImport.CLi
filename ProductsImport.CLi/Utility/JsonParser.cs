using Newtonsoft.Json;
using ProductsImport.CLi.Interfaces;
using ProductsImport.CLi.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProductsImport.CLi.Utility
{
    public class JsonParser : IParser
    {
        public IEnumerable<Product> ParseProducts(string path)
        {
            var products = new ProductCollection();
            try
            {
                string productData = String.Empty;
                using (StreamReader sr = new StreamReader("../../../" + path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        productData = productData + line.Trim();
                    }
                }
                products = JsonConvert.DeserializeObject<ProductCollection>(productData);
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine("Directory Not Found, please enter correct path");
            }
            catch (JsonReaderException exception)
            {
                Console.WriteLine("Data cannot be parsed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return products.Products;
        }
    }
}
