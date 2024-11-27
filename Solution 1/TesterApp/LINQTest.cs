using BLL;
using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    public class LINQTest
    {
        //will act like console UI
        static void Main(string[] args)
        {
            //List<Product> allProducts = BusinessManager.GetAllProducts();
            List<Product> allSoldOutProducts  =BusinessManager.GetSoldOutProducts();
            foreach (Product theProduct in allSoldOutProducts)
            {
                Console.WriteLine(theProduct.Title);
            }

            Console.ReadLine();
        }
    }
}
