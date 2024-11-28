using Catalog;


namespace BLL
{
    public static class BusinessManager
    {
        public static List<Product> GetDataFromDatabase()
        {
            List<Product> allProducts = new List<Product>();

            //Invoke backend data into .NET application
            // needed database connectivity 
            // you need to use
            // 1. ADO(Activex Data Object).NET Object Model (JDBC in java) or
            // 2. Entity Framwork (Hibernate in java)
            // connect to databse
            // query against database using SQL
            // get resultset from Query Processing
            // Craete List of Products from resultset
            // return list of Products

            return allProducts;
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product{ Id = 1, Title = "Rose", Description = "A beautiful red rose with a sweet fragrance.", UnitPrice = 12, Quantity = 5000 });
            allProducts.Add(new Product { Id = 2, Title = "Tulip", Description = "A vibrant yellow tulip, perfect for spring.", UnitPrice = 20, Quantity = 0 });
            allProducts.Add(new Product { Id = 3, Title = "Lily", Description = "Elegant white lilies with a delicate scent.", UnitPrice = 10, Quantity = 2000 });
            allProducts.Add(new Product { Id = 4, Title = "Daffodil", Description = "Bright orange daffodils to brighten any garden.", UnitPrice = 15, Quantity = 21000 });
            allProducts.Add(new Product { Id = 5, Title = "Sunflower", Description = "A tall sunflower with bright yellow petals.", UnitPrice = 10, Quantity = 0 });
            allProducts.Add(new Product { Id = 6, Title = "Orchid", Description = "Exotic orchids with vibrant purple flowers.", UnitPrice = 15, Quantity = 15000 });
            allProducts.Add(new Product { Id = 8, Title = "Lavender", Description = "Aromatic lavender flowers, perfect for relaxation.", UnitPrice = 7, Quantity = 0 });

            return allProducts;
        }


        public static IEnumerable<Product> GetSoldOutProducts()
        {
            List<Product> products = GetAllProducts();
            //Apply filter
            //Apply some buisness query
            //LINQ : Language Integrated Query
            //var soldOutProducts = from product in products select product;
            var soldOutProducts = from product in products
                                  where product.Quantity == 0 
                                  select product;


            return soldOutProducts;
        }
    }
}
