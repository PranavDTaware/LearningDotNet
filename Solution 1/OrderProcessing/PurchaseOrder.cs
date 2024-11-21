using CRM;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PurchaseOrder : Order
    {
        public Customer theCustomer { get; set; }
        public List<Item> Items = new List<Item>();

        public PurchaseOrder() { }
        public PurchaseOrder(int orderId, DateTime orderDate, Customer customer, List<Item> items)
        {
            this.OrderId = orderId;
            this.OrderDate = orderDate;
            this.theCustomer = theCustomer;
            this.Items = items;
        }
    }
}