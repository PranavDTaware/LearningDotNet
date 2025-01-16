
namespace DIWebApp.Services
{
    //Each Service should be defined by using contract

    public interface IProductCatalogService
    {
        string Insert();
        bool Update();
        bool Delete();
    }

    public class ProductCatalogService : IProductCatalogService
    {
        public string Insert()
        {
            return "insert product";
        }
        public bool Update()
        {
            bool status = false;
            return status;
        }
        public bool Delete()
        {
            bool status = false;
            return status;
        }
    }

}