using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class WorkOrderService:IOderService
    {
        private DeliveryManager mgr = new DeliveryManager();
        public WorkOrderService()
        {

        }

        public bool Cancel(Order order)
        {
            bool status = false;
            //cancelation logic for WorkOrder assigned
            return status;
        }

        public void Create(Order order)
        {
            //logic for creating work order
            Console.WriteLine("Order is created.....");
            mgr.Insert(order);
        }

        public void GetOrder (int orderId)
        {
            Order theOrder = new Order();
            //get the work order based on id sent

            return theOrder;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            //Get all WorkOrders orders
            return orders;
        }

        public bool Process(Order theorder)
        {

        }

        public bool Update(Order order)
        {
            bool status = false;
            // CRUD Operations update
            Console.WriteLine("Existing order details are updated...");
            return status;
        }
    }
}
