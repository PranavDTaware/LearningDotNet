using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Models;
using DIWebApp.Services;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    // SOA : Service Oriented Architecture
    // Dependencies : service
    // data members: 
    private readonly IHelloWorldService thehelloworldService;
    private readonly IProductCatalogService theproductCatalogService;
    public HomeController(IHelloWorldService helloWorldService, IProductCatalogService productCatalogService)
    {
        //are used for initialization
        this.thehelloworldService=helloWorldService;
        this.theproductCatalogService=productCatalogService;
    }

    public IActionResult Index()
    {
        string message = this.thehelloworldService.SayHello();
        ViewData["message"]= message;
        return View();
    }

    public IActionResult Privacy()
    {
        string message = this.theproductCatalogService.Insert();
        ViewData["message"]= message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
