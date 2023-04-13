using Microsoft.AspNetCore.Mvc;

namespace VendingMachineTracker.Controllers
{
    public class VendingMachineController : Controller
    {
        public IActionResult List()
        {
            return View("Views/Home/VendingMachine/List.cshtml");
        }
        public IActionResult Add()
        {
            return View("Views/Home/VendingMachine/Add.cshtml");
        }
        public IActionResult Details()
        {
            return View("Views/Home/VendingMachine/Details.cshtml");
        }
        public IActionResult Edit()
        {
            return View("Views/Home/VendingMachine/Edit.cshtml");
        }

    }
}
