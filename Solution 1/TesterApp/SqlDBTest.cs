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

            //Product theProduct = BusinessManager.GetProduct(0);
            //theProduct.UnitPrice = 100;
            //theProduct.Quantity = 1000;
            //status = BusinessManager.UpdateProduct(theProduct);

            //status = BusinessManager.DeleteProduct(0);


            Product newProduct = new Product();

            newProduct.Id = 9;
            newProduct.Title = "Jasmine";
            newProduct.Description = "Beautiful flower";
            newProduct.UnitPrice = 40;
            newProduct.Quantity = 1000;
            status = BusinessManager.InsertProduct(newProduct);



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
