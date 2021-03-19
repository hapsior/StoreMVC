using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreMVC.Application.Interfaces;
using StoreMVC.Models;
using StoreMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;
        public HomeController(ILogger<HomeController> logger,IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult ViewListOfItems(int id,string name)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Id = 1, Name = "NikeSneakers", Type = "Shoes" });
            items.Add(new Item { Id = 2, Name = "AdidasSneakers", Type = "Shoes" });
            items.Add(new Item { Id = 3, Name = "NikeHoodie", Type = "Clothes" });
            return View(items);

        }

        public IActionResult PartialTest()
        {

            return PartialView();
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
