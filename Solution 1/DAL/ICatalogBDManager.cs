using Catalog;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICatalogBDManager
    {
        Product GetProductByID(int productID);
        IEnumerable<Product> GetAllProducts();
        bool Insert(Product theProduct);
        bool Update(Product theProduct);
        bool Delete(int productID);

    }
}
