using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersConsoleApp
{
    public class ProductRepository
    {
        private List<Product> products;
        private const int MaxProducts = 100;

        public ProductRepository()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (products.Count < MaxProducts)
            {
                products.Add(product);
            }
            else
            {
                Console.WriteLine("Product repository is full!");
            }
        }

        public Product? GetProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                return products[index];
            }
            return null;
        }

        public Product? FindProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return null;
        }

        public Product? FindProductByTitle(string title)
        {
            foreach (var product in products)
            {
                if (product.Title == title)
                {
                    return product;
                }
            }
            return null;
        }

        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public void UpdateProduct(int index, Product product)
        {
            if (index >= 0 && index < products.Count)
            {
                var existingProduct = products[index];
                existingProduct.Title = product.Title;
                existingProduct.Description = product.Description;
                existingProduct.Category = product.Category;
                existingProduct.Quantity = product.Quantity;
                existingProduct.UnitPrice = product.UnitPrice;
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                product.Display();
                Console.WriteLine("------------------------");
            }
        }
    }
}
