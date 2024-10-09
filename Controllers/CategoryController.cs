using AutoBiography.Data;
using AutoBiography.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoBiography.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
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
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        
        public IActionResult Create()
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

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            if (ModelState.IsValid) {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int? id)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            if (id == null || id == 0) { 
                return NotFound();
            }
            Category? obj1 = _db.Categories.Find(id);
            //Category? obj2 = _db.Categories.FirstOrDefault(c => c.Id == id);
            //Category? obj3 = _db.Categories.Where(c => c.Id == id).FirstOrDefault();
            if(obj1 == null)
            {
                return NotFound();
            }
            return View(obj1);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            _db.Categories.Update(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? obj1 = _db.Categories.Find(id);
            if (obj1 == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj1);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
