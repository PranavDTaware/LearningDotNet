using Catalog;
using CRM;
using OrderProcessing;
using ShoppingCart;

namespace TesterApp
{
    class SingletonTest
    {
        static void Main(string[] args)
        {
            PurchaseManager mgr1, mgr2;
            mgr1 = PurchaseManager.GetManager();
            mgr2 = PurchaseManager.GetManager();
            
            
            Product product1 = new Product(1, "Rose", "Valentine flower", 500, 10);
            Product product2 = new Product(2, "Marigold", "Festival flower", 2000, 12);

            Item item1 = new Item(product1, 34);
            Item item2 = new Item(product2, 50);

            Cart cart1 = new Cart();

            cart1.AddToCart(item1);
            cart1.AddToCart(item2);


            List<Item> cartItems = cart1.Items;
            DateTime ordDate = DateTime.Now;
            Customer customer1 = new Customer
            {
                UserId = "100",
                FullName = "Pranav Taware",
                Email = "pranav@gmail.com",
                ContactNumber = "6545124565",
                Location = "Pune",
                Password = "seed"
            };

            Order theOrder = new PurchaseOrder(1001, ordDate, customer1, cartItems);

            mgr1.Orders = new List<Order>();
            mgr1.Orders.Add(theOrder);
        }
    }
}
