using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LearningApp.Models;
using OrderProcessing;

namespace LearningApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           List<Order> allOrders= OrderManager.GetAllOrders();
           this.ViewData["orders"]=allOrders;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Order order = OrderManager.GetById(id);
            this.ViewData["order"]=order;
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
 
        [HttpPost]
        public IActionResult Insert( int id,DateTime orderDate,string status, double totalAmount)
        {
            Order order = new Order(){
                Id = id,
                OrderDate = orderDate,
                Status = status,
                TotalAmount = totalAmount
            };
            OrderManager.Insert(order);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Order order = OrderManager.GetById(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Update( Order updatedOrder)
        {
            OrderManager.Update(updatedOrder);
            return RedirectToAction("Index", "Orders");
        }

        public ActionResult Delete(int id)
        {
            OrderManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
