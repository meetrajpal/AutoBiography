using AutoBiography.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoBiography.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName:"Auth", actionName:"Login");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}