using System;
using System.Collections.Generic;

namespace FlowersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List of Products
            List<Product> productList = new List<Product>();

            // Add sample products
            productList.Add(new Product(1, "Rose", "Fresh Red Rose", "Flowers", 10, 5.0f));
            productList.Add(new Product(2, "Tulip", "Yellow Tulip", "Flowers", 15, 4.5f));
            productList.Add(new Product(3, "Lily", "White Lily", "Flowers", 8, 6.0f));

            // Display all products
            Console.WriteLine("List of Products:");
            foreach (Product product in productList)
            {
                product.Display();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
