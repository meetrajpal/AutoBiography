using AutoBiography.Data;
using AutoBiography.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutoBiography.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HttpClient _httpClient;
        private readonly ILogger<GalleryController> _logger;
        public GalleryController(ApplicationDbContext db, HttpClient httpClient, ILogger<GalleryController> logger)
        {
            _db = db;
            _httpClient = httpClient;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string query = "car", int page = 1, int perPage = 12)
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
                ViewBag.SearchQuery = query;
                string[] collectionIds = await System.IO.File.ReadAllLinesAsync("wwwroot/collection_ids.txt");
                string formattedCollectionIds = string.Join(",", collectionIds);

                string apiUrl = $"https://api.unsplash.com/search/photos?query={query}&client_id=_0WKK3vG6LZYnpbYsEOvA8dLNVUheRvDk25SlE9DRQY&page={page}&per_page={perPage}&collections={formattedCollectionIds}";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                if (responseContent.Contains("Rate Limit Exceeded"))
                {
                    ViewBag.RateLimitExceded = true;
                    return View();
                }

                List<string> smallImageUrls = new List<string>();
                List<string> fullImageUrls = new List<string>();
                List<string> imageSlugs = new List<string>();

                JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(responseContent);

                int totalPages = (int)jsonResponse["total_pages"];
                _logger.LogInformation($"Manually Extracted Total Pages: {totalPages}");

                List<Result> results = jsonResponse["results"].ToObject<List<Result>>();

                if (results != null && results.Count > 0)
                {
                    foreach (var data in results)
                    {
                        if (data.Urls?.Small != null)
                            smallImageUrls.Add(data.Urls.Small);
                        if (data.Urls?.Full != null)
                            fullImageUrls.Add(data.Urls.Full);
                        if (data.Slug != null)
                            imageSlugs.Add(data.Slug);
                    }

                    ViewBag.SmallImageUrl = smallImageUrls.ToArray();
                    ViewBag.FullImageUrl = fullImageUrls.ToArray();
                    ViewBag.ImageSlugs = imageSlugs.ToArray();
                    ViewBag.CurrentPage = page;
                    ViewBag.TotalPages = totalPages;
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
    }
}
