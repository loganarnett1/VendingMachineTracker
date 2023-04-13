using Microsoft.AspNetCore.Mvc;

namespace VendingMachineTracker.Controllers
{
    public class ItemController : Controller
    {
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
