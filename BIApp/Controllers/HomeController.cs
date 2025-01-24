using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BIApp.Models;

namespace BIApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {

        //Using  ViewData
        string name = "Transflower Learning Pvt. Ltd.";
        ViewData["company"] = name;
        return View();
    }

    public IActionResult Services(){
             //Using TempData
            string service="Transforming Digital India";
            TempData["vision"]=service;
            return View();
        }

        public IActionResult SalesView(){
            SalesRepository list = new SalesRepository();
            ViewBag.Message = "Transflower Sales!";
            return View(list);
        }

        public IActionResult Students(){
            List<string> data=new List<string>();
            data.Add("Ajinkya");
            data.Add("Rohit");
            data.Add("Swarali");
            data.Add("Ankur");
            data.Add("Neha");
            data.Add("Rutuja");
            var result=data.ToArray();
            return new JsonResult(result);
        } 

        public IActionResult List(){

            SalesRepository repository=new SalesRepository();
            return new JsonResult(repository.products);
    
        }

        public IActionResult ClientSide()
        {
            
            return View();
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
