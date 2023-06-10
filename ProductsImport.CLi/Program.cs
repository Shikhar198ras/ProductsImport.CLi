using ProductsImport.CLi.Utility;
using System;
using System.Linq;

namespace ProductsImport.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = args.AsQueryable().FirstOrDefault();
            var path = args.AsQueryable().LastOrDefault();

            if (source == null)
            {
                Console.Write("Source: ");
                source = Console.ReadLine()!.Trim();
            }
            if (path == null)
            {
                Console.Write("Path: ");
                path = Console.ReadLine()!.Trim();
            }

            var products = new ParserSource().GetParser(path.Substring(path.IndexOf('.') + 1)).ParseProducts(path);

            foreach (var product in products)
            {
                Console.WriteLine("Importing: Name: " + product.Title + "; Categories: " + String.Join(',', product.Categories) + "; Twitter: " + product.Twitter);
            }
        }
    }
}
