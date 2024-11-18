using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class PurchaseOrder : Order
    {
        public Customer theCustomer { get; set; }
        public List<Item> Items - new List<Item>();

        public PurchaseOrder() { }

        public PurchaseOrder(int orderId, DateTime orderDate)
}
