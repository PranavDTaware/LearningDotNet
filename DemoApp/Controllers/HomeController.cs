using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DemoApp.Controllers;

[Serializable]

public class Cart{

     public List<string> Items = new List<string>();

     public Cart()
     {
        Items.Add("Smart Phone");
        Items.Add("Laptop");
        Items.Add("Camera");
        Items.Add("desktop");
     }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        string SessionKeyName = "product";
        string SessionKeyAge = "age";
        HttpContext.Session.SetString(SessionKeyName,"Dell Computer");
        HttpContext.Session.SetInt32(SessionKeyAge,45);
        var theCart = new Cart();
        var str = JsonSerializer.Serialize(theCart);
        HttpContext.Session.SetString("cart",str);
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.data = HttpContext.Session.GetString("product");
        ViewBag.data = HttpContext.Session.GetInt32("age");
        var strTheCart = HttpContext.Session.GetString("cart");
        ViewData["cart"] = JsonSerializer.Deserialize<Cart>(strTheCart);
        return View();
    }

    public IActionResult Connect()
    {
        string connectionString= string.Empty;
        //get connection stings from  apsetings.json file
        var connection = _configuration.GetValue<string>("ConnectionStrings:ConnectionStringActsDB");
        var connection1 = _configuration.GetSection("ConnectionStrings").GetSection("ConnectionStringActsDB").Value;
        var connection2 = _configuration["ConnectionStrings:ConnectionStringActsDB"];
        var connection3 = _configuration.GetConnectionString("ConnectionStringActsDB");

        List<string> connectionStrings=new List<string>();
        connectionStrings.Add(connection);
        connectionStrings.Add(connection1);
        connectionStrings.Add(connection2);
        connectionStrings.Add(connection3);

        // Initializing connection string
        ViewData["connectionStrings"]=connectionStrings;
        return View();
    }

    public IActionResult QueryTest()
    {
        string name=string.Empty;
        string city=string.Empty;
        string state=string.Empty;
        name=HttpContext.Request.Query["name"];
        city=HttpContext.Request.Query["city"];
        state=HttpContext.Request.Query["state"];
        return Content("Query Test fuction is invoked...." + name + " " + city + " " + state + " ");
    }

    public IActionResult Students(){
        List<string> data = new List<string>();
        data.Add("Ravi");
        data.Add("Pranav");
        data.Add("Ajinkya");
        data.Add("Manasi");
        
        var result=data.ToArray();
        //ViewResult
        return new JsonResult(result);
    }

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
