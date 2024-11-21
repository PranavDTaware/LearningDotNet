using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProcessing
{
    public class PurchaseOrderService : IOrderService
    {
        private List<Order> Orders = new List<Order>();
        
        PurchaseManager mgr = PurchaseManager.GetManager();

        public PurchaseOrderService()
        {

        }

        public bool Cancel(Order order)
        {
            bool status = false;
            return status;
        }

        public void Create(Order order)
        {
            Orders.Add(order);
        }

        public bool Update(Order order)
        {
            bool status = false;
            return status;
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }
    }
}
