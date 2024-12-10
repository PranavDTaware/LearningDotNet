using Catalog;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class CatalogDBDisconnectedManager : ICatalogBDManager
    {

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";


        //CRUD operations against database
        Product ICatalogBDManager.GetProductByID(int productID)
        {
            Product theProduct = null;

            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);

                da.Fill(ds);

                //Dataset is collection of Datatable objects retrived
                //from database after fill method 

                DataTable dt = ds.Tables[0];
                //DataTable is a collection of datarow objects 
                DataRow datarow = dt.Rows.Find(productID);
                datarow.Delete();
                da.Update(ds);


            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            return theProduct;
        }

        IEnumerable<Product> ICatalogBDManager.GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();

            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);   

                da.Fill(ds);

                //Dataset is collection of Datatable objects retrived
                //from database after fill method 


                DataTable dt = ds.Tables[0];
                //DataTable is a collection of datarow objects 

                foreach (DataRow datarow in dt.Rows)
                {

                    int id = int.Parse(datarow["productID"].ToString());
                    string title = datarow["title"].ToString();
                    string description = datarow["description"].ToString();
                    int unitPrice = int.Parse(datarow["price"].ToString());
                    int quantity = int.Parse(datarow["quantity"].ToString());

                    allProducts.Add(new Product()
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                    });
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            return allProducts;
        }

        bool ICatalogBDManager.Insert(Product theProduct)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                                
            }
            catch(SqlException exp) 
            {
                string msg = exp.Message;
            }

            return status;
        }
        
        bool ICatalogBDManager.Update(Product theProduct)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                                
            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return status;
        }   
        
        bool ICatalogBDManager.Delete(int productID)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                
            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return status;
        }

    }
}
