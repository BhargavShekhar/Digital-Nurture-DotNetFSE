using System;
using System.Collections.Generic;

namespace EcommerceSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize products
            List<Product> products = new List<Product>
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mouse", "Accessories"),
                new Product(103, "Keyboard", "Accessories"),
                new Product(104, "Monitor", "Electronics"),
                new Product(105, "Headphones", "Accessories"),
                new Product(106, "USB Cable", "Accessories"),
                new Product(107, "Desk Chair", "Furniture"),
                new Product(108, "Desk Lamp", "Furniture"),
                new Product(109, "Monitor Stand", "Accessories"),
                new Product(110, "Webcam", "Electronics")
            };

            SearchService searchService = new SearchService(products);

            // Test searches
            string[] searchQueries = { "Laptop", "Headphones", "Desk Chair", "Router" };

            foreach (string query in searchQueries)
            {
                Console.WriteLine($"Searching for {query} using Linear Search:");
                Product? linearResult = searchService.LinearSearch(query);
                DisplaySearchResult(linearResult);

                Console.WriteLine();

                Console.WriteLine($"Searching for {query} using Binary Search:");
                Product? binaryResult = searchService.BinarySearch(query);
                DisplaySearchResult(binaryResult);

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine();
            }

            // Display time complexity comparison
            Console.WriteLine("Time Complexity Comparison:");
            Console.WriteLine("Linear Search : O(n)");
            Console.WriteLine("Binary Search : O(log n)");
        }

        static void DisplaySearchResult(Product? product)
        {
            if (product != null)
            {
                Console.WriteLine("Product Found");
                product.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
    }
}
