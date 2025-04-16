using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersConsoleApp
{
    public class ProductService
    {
        private ProductRepository repo;

        public ProductService(ProductRepository repository)
        {
            this.repo = repository;
        }

        public void ApplyDiscount(int productId, double discount)
        {
            Product product = repo.FindProductById(productId);
            if (product != null)
            {
                float discountedPrice = product.GetDiscountedPrice();  //product.UnitPrice = (float)discountedPrice;
                product.UnitPrice = discountedPrice;
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void CalculateTotalPrice(int productId)
        {
            Product product = repo.FindProductById(productId);
            if (product != null)
            {
                double totalPrice = product.GetTotalPrice();
                Console.WriteLine($"Total Price for {product.Title}: ${totalPrice}");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void SearchProductByTitle(string title)
        {
            Product product = repo.FindProductByTitle(title);
            if (product != null)
            {
                product.Display();
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
