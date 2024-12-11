using Catalog;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class CatalogDBDisconnectedManager : ICatalogDBManager
    {

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";


        //CRUD operations against database

        Product ICatalogDBManager.GetProductByID(int productID)
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
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);

                //Dataset is collection of Datatable objects retrived
                //from database after fill method 

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
                // associate relation of columns as an primarykey at offline data in dataset


                //DataTable is a collection of datarow objects 
                DataRow datarow = dt.Rows.Find(productID);

                int id = int.Parse(datarow["productID"].ToString());
                string title = datarow["title"].ToString();
                string description = datarow["description"].ToString();
                int unitPrice = int.Parse(datarow["price"].ToString());
                int quantity = int.Parse(datarow["quantity"].ToString());

                theProduct = new Product()
                {
                    Id = id,
                    Title = title,
                    Description = description,
                    UnitPrice = unitPrice,
                    Quantity = quantity,
                };

            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            return theProduct;
        }

        bool ICatalogDBManager.Delete(int productID)
        {
            bool status = false;

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
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);

                //Dataset is collection of Datatable objects retrived
                //from database after fill method 

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables [0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
                // associate relation of columns as an primarykey at offline data in dataset


                //DataTable is a collection of datarow objects 
                DataRow datarow = dt.Rows.Find(productID);
                
                datarow.Delete();
                da.Update(ds);

                status = true;
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        IEnumerable<Product> ICatalogDBManager.GetAllProducts()
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

        bool ICatalogDBManager.Insert(Product theProduct)
        {
            bool status = false;

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
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);

                // Create empty row object
                DataRow datarow = ds.Tables[0].NewRow();

                // set data to newly created data row object
                datarow["productID"] = theProduct.Id;
                datarow["title"] = theProduct.Title;
                datarow["description"] = theProduct.Description;
                datarow["price"] = theProduct.UnitPrice;
                datarow["quantity"] = theProduct.Quantity;


                //add newly created row to rows collections maintained by tables[0]
                ds.Tables[0].Rows.Add(datarow);
                da.Update(ds); //commit------ at backend

            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return status;
        }

        bool ICatalogDBManager.Update(Product theProduct)
        {
            bool status = false;

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
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);

                //Dataset is collection of Datatable objects retrived
                //from database after fill method 

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
                // associate relation of columns as an primarykey at offline data in dataset


                //DataTable is a collection of datarow objects 
                DataRow datarow = dt.Rows.Find(theProduct.Id);
                datarow["title"] = theProduct.Title;
                datarow["description"] = theProduct.Description;
                datarow["price"] = theProduct.UnitPrice;
                datarow["quantity"] = theProduct.Quantity;
                da.Update(ds);

                status = true;
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }   
    }
}


// your code should be 
                    // simple to test
                    // simple to understand, readable
                    // reusable
                    // easily maintainable
                    // easily extensible
                    // should be automic in nature