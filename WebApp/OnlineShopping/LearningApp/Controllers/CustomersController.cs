using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LearningApp.Models;
using CRM;

namespace LearningApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           List<Customer> allCustomers= CRM.CustomerManager.GetAllCustomers();
           this.ViewData["customers"]=allCustomers;
            return View();  
        }
         public IActionResult Details(int id)
        {
            Customer customer =CustomerManager.GetById(id);
            this.ViewData["customer"]=customer;
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
 
        [HttpPost]
        public IActionResult Insert( int id,string name,string contactnumber,string email, string location, int age)
        {
            Customer customer = new Customer(){
                Id = id,
                Name = name,
                ContactNumber = contactnumber,
                Email = email,
                Location = location,
                Age = age
            };
            CustomerManager.Insert(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Customer customer = CustomerManager.GetById(id);
            return View(customer);
        }
 
        [HttpPost]
        public IActionResult Update( Customer updatedCustomer)
        {
            CustomerManager.Update(updatedCustomer);
            return RedirectToAction("Index", "Customers");
        }

        public IActionResult Delete(int id)
        { 
            CustomerManager.Delete(id);
            return RedirectToAction("Index", "Customers");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}