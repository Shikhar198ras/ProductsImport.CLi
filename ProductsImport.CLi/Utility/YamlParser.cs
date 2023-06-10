using ProductsImport.CLi.Interfaces;
using ProductsImport.CLi.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProductsImport.CLi.Utility
{
    public class YamlParser : IParser
    {
        public IEnumerable<Product> ParseProducts(string path)
        {
            IList<Product> products = new List<Product>();
            try
            {
                List<string> productData = new List<string>();
                Product product = null;
                using (StreamReader sr = new StreamReader("../../../" + path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        productData.Add(line);
                    }
                }
                foreach (string seq in productData)
                {
                    var sequence = seq.Trim();
                    if (sequence.Equals("-"))
                    {
                        if (product != null)
                            products.Add(product);
                        product = new Product();
                    }
                    if (sequence.StartsWith("tags"))
                    {
                        string tags = sequence.Substring(0, sequence.Length - 1);
                        product.Categories = tags.Substring(tags.IndexOf('"') + 1).Split(',');
                    }
                    if (sequence.StartsWith("name"))
                    {
                        string name = sequence.Substring(0, sequence.Length - 1);
                        product.Title = name.Substring(name.IndexOf('"') + 1);
                    }
                    if (sequence.StartsWith("twitter"))
                    {
                        string twitter = sequence.Substring(0, sequence.Length - 1);
                        product.Twitter = twitter.Substring(twitter.IndexOf('"') + 1);
                    }
                }
                if (product != null)
                    products.Add(product);
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine("Directory Not Found, please enter correct path");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return products;
        }
    }
}
