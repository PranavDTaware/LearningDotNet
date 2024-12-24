using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningApp.Models;

namespace LearningApp.Controllers;

public class AccountsController : Controller
{
    private readonly ILogger<AccountsController> _logger;

    public AccountsController(ILogger<AccountsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Logout()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult ForgotPassword()
    {
        return View();    
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
