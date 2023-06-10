using ProductsImport.CLi.Models;
using System.Collections.Generic;

namespace ProductsImport.Test
{
    public class MockData
    {
        public IEnumerable<Product> GetMockProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Title = "Freshdesk",
                    Twitter = "@freshdesk",
                    Categories = new List<string> { "Customer Service", "Call Center" }
                },
                new Product
                {
                    Title = "Zoho",
                    Categories = new List<string> { "CRM", "Sales Management" }
                }
            };
        }

        public IEnumerable<Product> GetYamlMockProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Title = "GitGHub",
                    Twitter = "github",
                    Categories = new List<string> { "Bugs & Issue Tracking", "Development Tools" }
                },
                new Product
                {
                    Title = "Slack",
                    Twitter = "slackhq",
                    Categories = new List<string> { "Instant Messaging & Chat", "Web Collaboration", "Productivity" }
                },
                new Product
                {
                    Title = "JIRA Software",
                    Twitter = "jira",
                    Categories = new List<string> { "Project Management", "Project Collaboration", "Development Tools" }
                }
            };
        }
    }
}
