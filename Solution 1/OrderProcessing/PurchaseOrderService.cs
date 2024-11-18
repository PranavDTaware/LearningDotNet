using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProcessing
{
    public class PurchaseOrderService : IOrderService
    {
        PurchaseManager mgr = new PurchaseManager();

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
            throw new NotImplementedException();
        }

        public bool Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
