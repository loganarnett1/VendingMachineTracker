using Microsoft.AspNetCore.Mvc;
using VendingMachineTracker.Models;
using VendingMachineTracker.Services;

namespace VendingMachineTracker.Controllers
{
    public class VendingMachineController : Controller
    {
        private ItemService itemService;
        private VendingMachineService vendingMachineService;
        public VendingMachineController(ItemService itemService, VendingMachineService vendingMachineService)
        {
            this.itemService = itemService;
            this.vendingMachineService = vendingMachineService;
        }

        [HttpGet]
        public IActionResult List() => View("Views/Home/VendingMachine/List.cshtml", vendingMachineService.getVendingMachines());

        [HttpGet]
        public IActionResult Add()
        {
            return View("Views/Home/VendingMachine/Add.cshtml");
        }

        [HttpGet]
        public IActionResult Details(int id) => View("Views/Home/VendingMachine/Details.cshtml", vendingMachineService.getVendingMachineById(id));

        [HttpGet]
        public IActionResult Edit(int id) => View("Views/Home/VendingMachine/Edit.cshtml", vendingMachineService.getVendingMachineById(id));

        [HttpPost]
        public RedirectToActionResult Edit(VendingMachine newVendingMachine)
        {
            vendingMachineService.modifyVendingMachine(newVendingMachine);
            //return RedirectToAction("List", vendingMachineService.getVendingMachines());
            return RedirectToAction("List");
        }
    }
}
