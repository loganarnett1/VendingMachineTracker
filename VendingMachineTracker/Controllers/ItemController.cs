using Microsoft.AspNetCore.Mvc;
using VendingMachineTracker.Services;

namespace VendingMachineTracker.Controllers
{
    public class ItemController : Controller
    {
        private ItemService itemService;
        private VendingMachineService vendingMachineService;
        public ItemController(ItemService itemService, VendingMachineService vendingMachineService)
        {
            this.itemService = itemService;
            this.vendingMachineService = vendingMachineService;
        }

        public IActionResult List()
        {
            return View("Views/Home/Item/List.cshtml");
        }
        public IActionResult Add()
        {
            return View("Views/Home/Item/Add.cshtml");
        }
        public IActionResult Details()
        {
            return View("Views/Home/Item/Details.cshtml");
        }
        public IActionResult Edit()
        {
            return View("Views/Home/Item/Edit.cshtml");
        }
    }
}
