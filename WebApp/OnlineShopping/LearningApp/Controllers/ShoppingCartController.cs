using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LearningApp.Models;
using ShoppingCart;

namespace LearningApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ILogger<ShoppingCartController> _logger;
        public ShoppingCartController(ILogger<ShoppingCartController> logger)
        {
            _logger = logger;
        }

         public IActionResult Index()
        {
            return View("Cart");
        }

        public IActionResult AddToCart()
        {

        }

        [HttpGet]
        public ActionResult RemoveFromCart(int id)
        { //Logic for removing item from Shopping cart kept in session
            return RedirectToAction("index");
        }
 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
