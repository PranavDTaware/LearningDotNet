using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersConsoleApp
{
    public class ProductController
    {
        private ProductRepository repo;
        private ProductService service;

        public ProductController(ProductRepository repository, ProductService productService)
        {
            this.repo = repository;
            this.service = productService;
        }

        public void AddProduct(int id, string title, string description, string category, int quantity, float price)
        {
            Product product = new Product(id, title, description, category, quantity, price);
            repo.AddProduct(product);
        }

        public void RemoveProduct(int index)
        {
            repo.RemoveProduct(index);
        }

        public void UpdateProduct(int index, Product product)
        {
            repo.UpdateProduct(index, product);
        }

        public void DisplayProducts()
        {
            repo.DisplayProducts();
        }

        public void ApplyDiscount(int productId, double discount)
        {
            service.ApplyDiscount(productId, discount);
        }

        public void CalculateTotalPrice(int productId)
        {
            service.CalculateTotalPrice(productId);
        }

        public void SearchProductByTitle(string title)
        {
            service.SearchProductByTitle(title);
        }

        public int GetProductId()
        {
            Console.Write("Enter Product ID: ");
            if (int.TryParse(Console.ReadLine(), out int productId))
            {
                return productId;
            }
            Console.WriteLine("Invalid input!");
            return -1;
        }

        public int GetProductIndex()
        {
            Console.Write("Enter Product Index: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                return index;
            }
            Console.WriteLine("Invalid input!");
            return -1;
        }

        public string GetProductTitle()
        {
            Console.Write("Enter Product Title: ");
            return Console.ReadLine();
        }
    }
}
