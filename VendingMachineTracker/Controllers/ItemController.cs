using Microsoft.AspNetCore.Mvc;
using VendingMachineTracker.Models;
using VendingMachineTracker.Services;

namespace VendingMachineTracker.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.getAllItems();
            return View(items);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Item item)
        {
            if (ModelState.IsValid)
            {
                _itemService.addItem(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = _itemService.getItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                _itemService.modifyItem(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = _itemService.getItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _itemService.removeItem(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

