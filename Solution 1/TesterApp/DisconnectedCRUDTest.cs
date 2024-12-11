using Catalog;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    public class DisconnectedCRUDTest
    {

        static void Main(string[] args)
        {
            //ICatalogBDManager mgr = new CatalogDBConnectedManager();
            ICatalogDBManager mgr = new CatalogDBDisconnectedManager();
            Product theProduct = mgr.GetProductByID(120);
            Console.WriteLine(theProduct.Title + " " + theProduct.Description);
            Console.ReadLine();
        }
    }
}
