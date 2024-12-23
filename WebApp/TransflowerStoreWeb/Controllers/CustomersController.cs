using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerStoreWeb.Models;
using CRM

namespace TransflowerStoreWeb.Controllers;

public class CustomersController : Controller
{
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }
   
    public IActionResult Index()
        {
           List<Customer> allCustomers= CRM.CustomerManager.GetAll();
           this.ViewData["customers"]=allCustomers;
            return View();  
        }

    public IActionResult Details()
    {
        return View();
    } 

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
