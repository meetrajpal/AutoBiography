using AutoBiography.Data;
using AutoBiography.DTO.REQ;
using AutoBiography.Models;
using AutoBiography.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoBiography.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AuthController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginReqDto req)
        {
            if (ModelState.IsValid) { 
                UserProfile? user = _db.Users.FirstOrDefault(data => data.Username == req.Username);
                if (user == null)
                {
                    ModelState.AddModelError("Username", "Username Not Found.");
                    return View(req);
                }
                else {
                    var userService = new UserService();
                    bool isPasswordValid = userService.VerifyPassword(user, user.Password, req.Password);

                    if (!isPasswordValid)
                    {
                        ModelState.AddModelError("Password", "Invalid Password");
                        return View(req);
                    }
                    
                    var cookieOptions = new CookieOptions
                    { 
                        HttpOnly = true,                   
                        Secure = true,                     
                        SameSite = SameSiteMode.Strict
                    };

                    HttpContext.Response.Cookies.Append("UserInfo", req.Username, cookieOptions);

                    return RedirectToAction(controllerName: "Home", actionName: "Index");
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("UserInfo");
            ViewBag.UserInfo = null;
            return RedirectToAction(actionName: "Login");
        }
    }
}
