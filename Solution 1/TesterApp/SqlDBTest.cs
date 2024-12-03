using BLL;
using Catalog;

namespace TesterApp
{
    public class SqlDBTest
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to database connectivity");

            bool status = false;

            Product theProduct = BusinessManager.GetProduct(1);
            theProduct.UnitPrice = 99;
            theProduct.Quantity = 99999;
            status = BusinessManager.UpdateProduct(theProduct);

            //status = BusinessManager.DeleteProduct(9);

            IEnumerable<Product> allProducts = BusinessManager.GetAllProducts();
            foreach(Product product in allProducts)
            {
                Console.WriteLine("Title = {0}, Quantity = {1}", product.Title, product.Quantity);
                Console.WriteLine("Description = {0}", product.Description);
            }

            Console.ReadLine();
        }
    }
}
