using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomRoutingApp.Models;

namespace CustomRoutingApp.Controllers;

public class FarmsController : Controller
{

    public IActionResult GreenhouseDetails(string farmName, string unitNo)
    {
        Console.WriteLine("Farm name = "+ farmName + "Greenhouse name = " + unitNo);
        return View();
    }

    public IActionResult CropDetails(string farmName, string unitNo, string cropName)
    {
        Console.WriteLine("Farm name = "+ farmName + "Greenhouse name = " + unitNo + "Crop details = " + cropName);
            return View();
    }

    public IActionResult CropDateDetails(string farmName, string unitNo, string cropName,string date)
    {
        Console.WriteLine("Farm name = "+ farmName + " Greenhouse name = "+ unitNo + "Crop name" +cropName + "Date "+ date);
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
