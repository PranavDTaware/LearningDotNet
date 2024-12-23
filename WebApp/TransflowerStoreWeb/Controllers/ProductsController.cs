using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerStoreWeb.Models;

namespace TransflowerStoreWeb.Controllers;


// Controller is a kind of class for defining action methods for each incoming HTTP request
// http: //localhost: 5000/Products/index
// http: //localhost: 5000/Products/details
// http: //localhost: 5000/Products/insert
// http: //localhost: 5000/Products/update
public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //action method handles HTTP request by providing logic and send view to razor view engine    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    } 


    // GET request for insert
    public IActionResult Insert()
    {
        Console.WriteLine("GET HTTP insert method is invoked");
        return View();
    }

    public IActionResult Insert(string title, string description, int quantity, double unitprice )
    {
        Console.WriteLine("POST HTTP insert m ethod is invoked");
        return View();
    }

    [HttpPost]
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
