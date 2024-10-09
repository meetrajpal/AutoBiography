using AutoBiography.Data;
using AutoBiography.Models;
using AutoBiography.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoBiography.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserProfileController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string? username)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            if (username == null)
            {
                return NotFound();
            }

            UserProfile? userProfile = _db.Users.FirstOrDefault(data => data.Username == username);
            if (userProfile == null) { 
                return NotFound();
            }
            return View(userProfile);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        async public Task<IActionResult> Create(UserProfile user)
        {
            
            if (ModelState.IsValid)
            {
                UserProfile? userProfile = _db.Users.FirstOrDefault(data => data.Username == user.Username);
                if (userProfile != null)
                {
                    ModelState.AddModelError("Username", "This username is already taken.");
                    return View(user);
                }
                userProfile = _db.Users.FirstOrDefault(data => data.Email == user.Email);
                if (userProfile != null)
                {
                    ModelState.AddModelError("Email", "This Email is already in use.");
                    return View(user);
                }

                var userService = new UserService();
                user.Password = userService.HashPassword(user, user.Password);

                if (user.Picture != null)
                {
                    var filePath = Path.Combine("wwwroot/images", user.Picture.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await user.Picture.CopyToAsync(stream);
                    }

                    user.PicUri = "/images/" + user.Picture.FileName;
                }

                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            UserProfile? userProfile = _db.Users.FirstOrDefault(data => data.Id == id);
            if (userProfile == null)
            {
                return NotFound();
            }

            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = null;
                HttpContext.Response.Cookies.Delete("UserInfo");
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }

            if (userProfile.PicUri != null)
            {
                var filePath = Directory.GetCurrentDirectory() + "\\wwwroot" + userProfile.PicUri.Replace('/', '\\');
                Console.WriteLine(filePath);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }

            _db.Users.Remove(userProfile);
            _db.SaveChanges();

            return RedirectToAction(controllerName:"Auth", actionName:"Login");
        }
    }
}