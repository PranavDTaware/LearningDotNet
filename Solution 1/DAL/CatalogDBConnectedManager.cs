using Catalog;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class CatalogDBConnectedManager : ICatalogBDManager
    {

        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";


        //CRUD operations against database

        //read

        Product ICatalogBDManager.GetProductByID(int productID)
        {
            Product theProduct = null;
            // using connected data access mod

            try
            {
                using(IDbConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    IDbCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string query = "SELECT * FROM flowers WHERE productID = @Id";

                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@Id", productID));

                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = int.Parse(reader["productID"].ToString());
                        string title = reader["title"].ToString();
                        string description = reader["description"].ToString();
                        int unitPrice = int.Parse(reader["price"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());

                        theProduct = new Product
                        {
                            Id = id,
                            Title = title,
                            Description = description,
                            UnitPrice = unitPrice,
                            Quantity = quantity,
                        };
                    }


                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                
            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return theProduct;
        }

        IEnumerable<Product> ICatalogBDManager.GetAllProducts()
        {
            //Invoke backend data into .NET application
            // needed database connectivity 
            // you need to use
            // 1. ADO(Active Data Object).NET Object Model (JDBC in java) or
            // 2. Entity Framwork (Hibernate in java)
            // connect to databse
            // query against database using SQL
            // get resultset from Query Processing
            // Craete List of Products from resultset
            // return list of Products
            List<Product> allProducts = new List<Product>();
           
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;


            try
            {
                //using Connected data access of ADO .net

                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["productID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int unitPrice = int.Parse(reader["price"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());

                    Product theProduct = new Product
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                    };
                    allProducts.Add(theProduct);
                }
                reader.Close();
            }
            catch(SqlException exp)
            {
                string message = exp.Message;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allProducts;
        }

        bool ICatalogBDManager.Insert(Product theProduct)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "INSERT INTO flowers (productID, title, description, price, quantity)" +
                               "VALUES (@Id, @Title, @Description, @Price, @Quantity)";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title",theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description",theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Price", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                con.Open();
                cmd.ExecuteNonQuery();
                
                status = true;

                if(con.State == ConnectionState.Open)
                    con.Close();
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
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "UPDATE flowers SET title = @Title, description = @Description, price = @UnitPrice, quantity = @Quantity " + 
                               "WHERE productID = @Id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", (int)theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                con.Open();
                cmd.ExecuteNonQuery();

                status = true;

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return status;
        }   
        
        bool ICatalogBDManager. Delete(int productID)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "DELETE FROM flowers WHERE productID = @Id";

                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", productID));

                con.Open();
                cmd.ExecuteNonQuery();

                status = true;

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string msg = exp.Message;
            }

            return status;
        }

    }
}
