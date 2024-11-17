using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProcessing
{
    class WorkOrderTest
    {
        public static void Main(string[] args)
        {
            DateTime ordDate = DateTime.Now;

            Job job1 = new Job
            {
                ID = 1,
                Title = "Collect parcel from amazon Stores",
                Description = "Collect all todays parcels to be delivered from Mumbai warehouse",
                Duration = 3,
                Status = "Not started"
            };
            Job job2 = new Job { ID = 2, Title = "Deliver parcel to customers", Description = "All parcels collected to be delivered to " };
            Job job3 = new Job { ID = 3, Title = "Report the status of delivery", Description = "Collect all todays parcel to be delivered" };
            Job job4 = new Job { ID = 4, Title = "Update Workorder Status", Description = "Access online amazon system to update status of " };
        
            
            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);

            Order theOrder = new WorkOrder
            {
                OrderId = 101,
                Vendor = "DHL Group",
                Description = "Parcel Delivery to Amazon Customers",
                OrderDate = DateTime.Now,
                StartDate = new DateTime(2024, 11, 20),
                EndDate = new DateTime(2024, 11, 30),
                Jobs = jobs,
                Priority = 4,
                Status = "Not Started"
            };

            IOrderService service = new WorkOrderService();
            service.Create(theOrder);

            List
        }
    }
}
