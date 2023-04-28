using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VendingMachineTracker.Models;
using VendingMachineTracker.Services;

namespace VendingMachineTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ItemService itemService;
        private VendingMachineService vendingMachineService;

        public HomeController(ILogger<HomeController> logger, ItemService itemService, VendingMachineService vendingMachineService)
        {
            _logger = logger;
            this.itemService = itemService;
            this.vendingMachineService = vendingMachineService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
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
