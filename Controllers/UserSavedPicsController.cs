using AutoBiography.Data;
using AutoBiography.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoBiography.Controllers
{
    public class UserSavedPicsController : Controller
    {

        private readonly ApplicationDbContext _db;
        public UserSavedPicsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveImage(UserSavedPics userSavedPics, int page, string query)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            if (ModelState.IsValid && _db.UserSavedPics.FirstOrDefault(pic => pic.ThumbUri == userSavedPics.ThumbUri && pic.Username == userSavedPics.Username) == null) {
                _db.UserSavedPics.Add(userSavedPics);
                _db.SaveChanges();
            }
            return RedirectToAction(actionName: "Index", controllerName: "Gallery", new { page = page, query = query });
        }
    }
}
