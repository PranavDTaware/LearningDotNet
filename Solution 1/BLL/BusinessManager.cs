using Catalog;


namespace BLL
{
    public static class BusinessManager
    {

        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product{ Id = 1, Title = "Rose", Description = "A beautiful red rose with a sweet fragrance.", UnitPrice = 12, Quantity = 5000 });
            allProducts.Add(new Product { Id = 2, Title = "Tulip", Description = "A vibrant yellow tulip, perfect for spring.", UnitPrice = 20, Quantity = 0 });
            allProducts.Add(new Product { Id = 3, Title = "Lily", Description = "Elegant white lilies with a delicate scent.", UnitPrice = 10, Quantity = 2000 });
            allProducts.Add(new Product { Id = 4, Title = "Daffodil", Description = "Bright orange daffodils to brighten any garden.", UnitPrice = 15, Quantity = 40 });
            allProducts.Add(new Product { Id = 5, Title = "Sunflower", Description = "A tall sunflower with bright yellow petals.", UnitPrice = 10, Quantity = 0 });
            allProducts.Add(new Product { Id = 6, Title = "Orchid", Description = "Exotic orchids with vibrant purple flowers.", UnitPrice = 15, Quantity = 15 });
            allProducts.Add(new Product { Id = 8, Title = "Lavender", Description = "Aromatic lavender flowers, perfect for relaxation.", UnitPrice = 7, Quantity = 0 });

            return allProducts;
        }


        public static List<Product> GetSoldOutProducts()
        {
            List<Product> products = GetAllProducts();
            //Apply filter
            //Apply some buisness query
            //LINQ : Language Integrated Query
            var soldOutProducts = from product in products select product;



            return soldOutProducts as List<Product>;
        }
    }
}
