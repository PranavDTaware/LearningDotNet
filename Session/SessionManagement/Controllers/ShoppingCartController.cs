using Microsoft.AspNetCore.Mvc;
using SessionManagement.Models;
using  Core.Models;
using Core.Services.Interfaces;
using SessionManagement.Helpers;

namespace SessionManagement.Controllers
{
   public class ShoppingCartController : Controller
    {
        private const string CartSessionKey = "cart";
        private readonly IFlowerService _flowerService;
        private readonly IOrderService _orderService;

        public ShoppingCartController(IFlowerService flowerService, IOrderService orderService)
        {        
            _flowerService=flowerService;
            _orderService=orderService;
        }
        public IActionResult Index(){  
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null)
            {
                theCart = new Cart();
                theCart.Items = new List<Item>(); // Ensure Items is initialized
            }
            return View(theCart);
        }


        [HttpGet]
        public IActionResult  Add(int id){  
            Flower theFlower=_flowerService.GetById(id);
            Item theItem=new Item();
            theItem.theFlower=theFlower;
            theItem.Quantity=0;
            return View(theItem);
        }
        [HttpPost]
        public IActionResult Add(Item newItem)
        {
            Console.WriteLine("new Item = {0}", newItem.ID);  
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null)
                {
                    theCart = new Cart();
                    theCart.Items = new List<Item>(); // Initialize the Items list if necessary
                }
            theCart.Items.Add(newItem);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index","shoppingcart");
        }

        public IActionResult  Remove(int  id)
        {
            Console.WriteLine("id = {0}", id );  
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");  
            var found = theCart.Items.Find(x => x.theFlower.ID == id);
            if(found != null)
            {
                Console.WriteLine("found = {0}", found);
                theCart.Items.Remove(found);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index","ShoppingCart");
        }
        public IActionResult BuyNow()
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null || theCart.Items == null || ! theCart.Items.Any())
                {
                    return RedirectToAction("Index", "ShoppingCart");
                }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "buyNowCart", theCart);
            return View(theCart);
        }
   }
}