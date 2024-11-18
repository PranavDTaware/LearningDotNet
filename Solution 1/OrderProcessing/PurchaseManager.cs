using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PurchaseManager
    {
        List<Order> orders = new List<Order>();

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public void Insert(Order order)
        {
            orders.Add(order);
        }
        public void Update(Order order)
        {
            foreach (Order ord in this.orders)
            {
                if (ord.OrderId == order.OrderId)
                {
                }
            }
        }
    }
}
