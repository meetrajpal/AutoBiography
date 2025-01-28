using AutoBiography.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using AutoBiography.DTO.RES;

namespace AutoBiography.Controllers
{
    public class UserSavedPicsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationDbContext _db;
        public UserSavedPicsController(ApplicationDbContext db, HttpClient httpClient)
        {
            _db = db;
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int perPage = 12)
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
            {
                ViewBag.UserInfo = userInfo;
            }
            else
            {
                return RedirectToAction(controllerName: "Auth", actionName: "Login");
            }

            try
            {
                
                string apiUrl = $"{Environment.GetEnvironmentVariable("AUTO_BIO_API")}/api/user-saved-pics?username={ViewBag.UserInfo}&page={page}&pageSize={perPage}";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();

                List<string> smallImageUrls = new List<string>();
                List<string> fullImageUrls = new List<string>();
                List<string> imageSlugs = new List<string>();
                List<int> imageIds = new List<int>();

                JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(responseContent);

                int totalPages = (int)jsonResponse["totalPages"];

                List<AutoBiographyAPIResDto> results = jsonResponse["userSavedPicsList"].ToObject<List<AutoBiographyAPIResDto>>();

                if (results != null && results.Count > 0)
                {
                    foreach (var data in results)
                    {
                        imageIds.Add(data.Id);
                        if (data.ThumbUri != null)
                            smallImageUrls.Add(data.ThumbUri);
                        if (data.FullUri != null)
                            fullImageUrls.Add(data.FullUri);
                        if (data.Slug != null)
                            imageSlugs.Add(data.Slug);
                    }

                    ViewBag.SmallImageUrl = smallImageUrls.ToArray();
                    ViewBag.FullImageUrl = fullImageUrls.ToArray();
                    ViewBag.ImageSlugs = imageSlugs.ToArray();
                    ViewBag.ImageIds = imageIds.ToArray();
                    ViewBag.CurrentPage = page;
                    ViewBag.TotalPages = totalPages;
                    ViewBag.ApiUrl = Environment.GetEnvironmentVariable("AUTO_BIO_API");
                }

                return View();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
                return View(e);
            }
        }

        //[HttpPost]
        //public IActionResult SaveImage(UserSavedPics userSavedPics, int page, string query)
        //{
        //    if (HttpContext.Request.Cookies.TryGetValue("UserInfo", out string? userInfo))
        //    {
        //        ViewBag.UserInfo = userInfo;
        //    }
        //    else
        //    {
        //        return RedirectToAction(controllerName: "Auth", actionName: "Login");
        //    }
        //    if (ModelState.IsValid && _db.UserSavedPics.FirstOrDefault(pic => pic.ThumbUri == userSavedPics.ThumbUri && pic.Username == userSavedPics.Username) == null) {
        //        _db.UserSavedPics.Add(userSavedPics);
        //        _db.SaveChanges();
        //    }
        //    return RedirectToAction(actionName: "Index", controllerName: "Gallery", new { page = page, query = query });
        //}
    }
}
