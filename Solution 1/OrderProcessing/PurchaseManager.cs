using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{

    // Singleton pattern 
    // allow only one instance of a class to be created
    // 1.define private constructor
    // 2.Keep self reference as static variable to class 
    // 3.Create instance of class by verifying reference nullability
    //   with the help of static method 
    public class PurchaseManager
    {
        List<Order> orders = new List<Order>();

        private static PurchaseManager _ref = null;

        private PurchaseManager() { }

        public static PurchaseManager GetManager()
        {
            if(_ref == null)
            {
                _ref = new PurchaseManager();
                return _ref;
            }
            else
                return _ref;
        }
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
                    orders.Add(order);
            }
        }

        public void Delete(Order order)
        {
            orders.Remove(order);
        }
        public List<Order> GetAll()
        {
            return orders;
        }

        public Order GetOrderByID(int orderId)
        {
            foreach (Order order in this.orders)
            {
                if (order.OrderId == orderId)
                    return order;
            }
            return null;
        }

        public List<Order> GetByCustomerID(string custid)
        {
            List<Order> orders = new List<Order>();
            foreach (PurchaseOrder order in this.orders)
            {
                if (order.theCustomer.UserId == custid)
                    return orders;
            }
            return orders;
        }
    }
}
