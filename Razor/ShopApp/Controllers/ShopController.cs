using ShopApp.Models;
using ShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class ShopController : Controller
    {
        private ShopsService _shopsService;

        public ShopController(ShopsService shopsService)
        {
            _shopsService = shopsService;
        }

        public IActionResult Index()
        {
            var shops = _shopsService.GetAll();
            return View(shops);
        }
        [HttpGet]
        public IActionResult Add()
        {
            Shop shop = new Shop();
            return View(shop);
        }
        [HttpPost]
        public IActionResult Add(Shop shop)
        {
            _shopsService.Add(shop);
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(string name)
        {
            _shopsService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
