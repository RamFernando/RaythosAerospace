using Microsoft.AspNetCore.Mvc;
using RaythosAerospace.Data.Services;
using RaythosAerospace.Models;

namespace RaythosAerospace.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryService _service;

        public InventoryController(IInventoryService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Aircraft);
            return View(data);
        }

        //Inventory/Create

        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to Raythos";
            return View();
        }

        //Get: Inventory/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var inventoryDetails = await _service.GetInventoryByIdAsync(id);

            Console.WriteLine(inventoryDetails);

            if (inventoryDetails == null) return View("NotFound");

            var response = new Inventory()
            {
                Id = inventoryDetails.Id,
                Quantity = inventoryDetails.Quantity,
                RestockDate = inventoryDetails.RestockDate,
                AircraftId = inventoryDetails.AircraftId,
                Aircraft = inventoryDetails.Aircraft
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Inventory inventory)
        {

            if (id != inventory.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                foreach (var errorMessage in errorMessages)
                {
                    Console.WriteLine(errorMessage);
                }

                ViewBag.ErrorMessages = errorMessages;
                return View(inventory);
            }
            await _service.UpdateInventoryAsync(inventory);
            return RedirectToAction(nameof(Index));
        }
    }
}
