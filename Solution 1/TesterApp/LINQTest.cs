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
            List<Product> allProducts = BusinessManager.GetAllProducts();
            //List<Product> allSoldOutProducts  =BusinessManager.GetSoldOutProducts();
            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title);
            }


            //Specify the data source
            int[] scores = new int[] { 89, 54, 66, 64 };

            //Define the query expression
            IEnumerable<int> result = from score in scores 
                                          where score > 80
                                          select score;

            foreach (int score in result)
            {
                Console.WriteLine(score);
            }

            List<int> numbers = new List<int>() { 1, 3, 5, 6, 4, 7, 5, 2, 6, 4, 0, 10, 23,11 };
            
            Console.WriteLine(numbers);
            // the query variable can also be implicitly typed by using var
            IEnumerable<int> filteringQuery = from num in numbers
                                              where num < 3 || num > 7
                                              select num;

            Console.WriteLine("show numbers which are not in between 3 & 7");
            foreach(int score in filteringQuery)
            {
                Console.WriteLine(score);
            }

            //Query 2
            IEnumerable<int> orderingQuery = from num in numbers
                                             where num < 3 || num >7
                                             orderby num ascending
                                             select num;

            Console.WriteLine("show numbers which are not in between in ascending order");
            foreach (int score in orderingQuery)
            {
                Console.WriteLine(score);
            }



            //var allSoldOutProducts = from product in allProducts
            //                         where product.Quantity == 0 
            //                         select product;



            IEnumerable<Product> allSoldOutProducts = BusinessManager.GetSoldOutProducts();
            Console.WriteLine(" Show only those products title which are sold out");
            
            foreach (Product theProduct in allSoldOutProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Quantity);
            }



            Console.ReadLine();
        }
    }
}
