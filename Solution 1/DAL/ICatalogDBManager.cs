using Catalog;


namespace DAL
{
    public interface ICatalogDBManager
    {
        Product GetProductByID(int productID);
        IEnumerable<Product> GetAllProducts();
        bool Insert(Product theProduct);
        bool Update(Product theProduct);
        bool Delete(int productID);

    }
}
