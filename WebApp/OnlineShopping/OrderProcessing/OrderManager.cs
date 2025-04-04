
using System;
using System.Data;
using System.Collections.Generic;

namespace OrderProcessing
{
     public  static class OrderManager
    {   
         public static List<Order> GetAllOrders() 
        {
            List<Order> Orders = new List<Order>();
            Orders = GetAllOrdersFromDatabase();
            return Orders;
        }
        public static List<Order> GetAllOrdersFromDatabase()
        {
            List<Order> allOrders = OrderDBManager.GetAll();
            return allOrders;
        }
        public static Order GetById(int OrderId)
        {
            List<Order> orders = GetAllOrders();
            Order theOrder = orders.FirstOrDefault(p=>p.Id == OrderId);
            return theOrder;
        }
        public static bool Insert(Order Order)
        {
            bool status = false;
            status = OrderDBManager.Insert(Order);
            return status;
        }
        public static bool Update(Order order)
        {
            bool status = false;
            status=OrderDBManager.Update(order);
            return status;
        }
        public static bool Delete(int OrderId)
        {
            bool status = false;
            status = OrderDBManager.Delete(OrderId);
            return status;
        }     
  }
}