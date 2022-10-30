using HomeWork7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork7.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public JsonResult GetJson()
        {
            using (FileStream fStream = new FileStream(@"C:\Users\Юра\source\repos\HomeWork7\HomeWork7\Files\users.json", FileMode.OpenOrCreate))
            {
                object? users = System.Text.Json.JsonSerializer.Deserialize<object>(fStream);
                return Json(users);
            }
        }
    }
}