using Core.Models;
using Core.Repositories.Interfaces;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll()
        {
            //In a real project, this is where you would call your database/datastore for this info
            using (var context = new RepoCollectionContext())
            {
             var orders = from prod in context.Orders select prod;
             return orders.ToList<Order>();
            }
        }
        public Order GetById(int id)
        {
            List<Order> allOrders=GetAll();
            var found = allOrders.Find(x => x.Id == id);
            Order theOrder=found as Order;
            return theOrder;
        }
    }
}
