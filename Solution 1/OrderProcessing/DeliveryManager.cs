using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class DeliveryManager : Manager
    {
        List<Order> orders = new List<Order>();
        public List<Order> Orders;
        public void Insert(Order order)
        {
            orders.Add(order);
        }

        public void Update(Order order)
        {

        }

        public void Delete(Order order)
        {
            orders.Remove(order);
        }
    }
}
