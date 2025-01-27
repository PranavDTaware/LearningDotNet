using Core.Models;
using Microsoft.AspNetCore.Mvc;
using SessionManagement.Models;

namespace SessionManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            var loginModel = new Login();
            return View(loginModel);
        }

        public IActionResult Registration()
        {
            var register = new Registration();
            return View(register);
        }
    }
}
