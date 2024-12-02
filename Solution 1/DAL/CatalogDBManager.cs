using Catalog;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public static class CatalogDBManager
    {
        //CRUD operations against database

        //read
        public static IEnumerable<Product> GetAllProducts()
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
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";
            
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

        public static IEnumerable<Product> GetAllProductsUsingDisconected()
        {
            List<Product> allProducts = new List<Product>();

            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";

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

        //create
        public static bool Insert(Product theProduct)
        {
            bool status = false;
            // using connected data access mod

            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\FullStack\LearningDotNet\Solution 1\TesterApp\ECommerce.mdf"";Integrated Security=True";
                IDbCommand cmd = new SqlCommand();
                string query = "INSERT INTO flowers (productID, title, description, price, quantity)" +
                               "VALUES (@Id, @Title, @Description, @Price, @Quantity)";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title",theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description",theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Price", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));

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

        //update
        public static bool Update(Product theProduct)
        {
            bool status = false;

            //logic for updation
            return status;
        }

        //delete
        public static bool Delete(int productID)
        {
            bool status = false;

            //logic for deletion
            return status;
        }

    }
}
