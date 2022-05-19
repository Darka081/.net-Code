using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopApp.Models;
using System.Diagnostics;
using ShopApp.Services;

namespace ShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopsService _shopsService;

        public HomeController(ILogger<HomeController> logger, ShopsService shopService)
        {
            _logger = logger;
            _shopsService = shopService;
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
    }
}
