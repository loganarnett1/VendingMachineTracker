using Microsoft.AspNetCore.Mvc;
using VendingMachineTracker.Models;
using VendingMachineTracker.Services;

namespace VendingMachineTracker.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            var items = _itemRepository.GetItems();
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
                _itemRepository.AddItem(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            Item item = _itemRepository.GetItemById(id);
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
                _itemRepository.UpdateItem(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            Item item = _itemRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _itemRepository.DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}
