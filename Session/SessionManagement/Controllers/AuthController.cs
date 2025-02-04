﻿using Core.Models;
using Core.Services;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionManagement.Models;
using System.Xml.Linq;

namespace SessionManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _authService.Validate(username, password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserID", user.Id);
                return RedirectToAction("orderconfirmation", "Orders");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid email or password, Please try again.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Registration(int id, string name, string username, string email, string phoneNumber, string location, string password)
        {
            User register = new User()
            {
                Id = id,
                Name = name,
                UserName = username,
                Password = password,
                PhoneNumber = phoneNumber,
                Email = email,
                Location = location,
            };
            _authService.Register(register);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(string username, string newPassword, string confirmPassword)
        {
            var user = _authService.ForgotPassword(username, newPassword, confirmPassword);
            if (user != null)
            {
                HttpContext.Session.SetString("UserId", user.ToString());
                return RedirectToAction("Login", "Auth");
            }

            ViewBag.Message = "Failed to update password. Please check your inputs.";
            return View();

        }
    }
}
