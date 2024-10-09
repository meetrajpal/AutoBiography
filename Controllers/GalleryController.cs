using AutoBiography.Data;
using AutoBiography.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoBiography.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GalleryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            List<Gallery> objGalleryList = _db.Gallery.ToList();
            return View(objGalleryList);
        }
    }
}
