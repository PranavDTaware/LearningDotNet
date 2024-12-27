
using System;
using System.Data;
using System.Collections.Generic;

namespace CRM
{
     public  static class CustomerManager
    {
         public static List<Customer> GetAllCustomers() 
        {
            List<Customer> customers = new List<Customer>();
            customers =  GetAllCustomersFromDatabase();
            return customers;
        }

        public static List<Customer> GetAllCustomersFromDatabase()
        {
            List<Customer> allCustomers = CustomerDBManager.GetAll();
            return allCustomers;
        }

        public static Customer GetById(int customerId)
        {
            List<Customer> customers = GetAllCustomers();
            Customer theCustomer = customers.FirstOrDefault(p => p.Id == customerId);
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            status=CustomerDBManager.Delete(customerId);
            return status;
        }   
        public static bool Update(Customer customer)
        {
            bool status = false;
            status=CustomerDBManager.Update(customer);
            return status;
        }
        public static bool Insert(Customer customer)
        {
            bool status = false;
            status = CustomerDBManager.Insert(customer);
            return status;
        }
  }
}