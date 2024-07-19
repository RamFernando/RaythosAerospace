using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaythosAerospace.Data;
using RaythosAerospace.Data.Services;
using RaythosAerospace.Models;

namespace RaythosAerospace.Controllers
{
    public class AircraftController : Controller
    {
        private readonly IAircraftService _service;

        public AircraftController(IAircraftService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Aircraft/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ImageURL, ModelName, Specifications, BasePrice")]Aircraft aircraft)
        {
            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                foreach (var errorMessage in errorMessages)
                {
                    Console.WriteLine(errorMessage);
                }
                return View(aircraft);
            }
            await _service.AddAsync(aircraft);
            return RedirectToAction(nameof(Index));
        }

        //Get: Aircraft/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var aircraftDetails = await _service.GetByIdAsync(id);

            if (aircraftDetails == null) { return View("NotFound"); }
            return View(aircraftDetails);
        }

        //Get: Aircraft/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var aircraftDetails = await _service.GetByIdAsync(id);

            if (aircraftDetails == null) { return View("NotFound"); }
            return View(aircraftDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, ImageURL, ModelName, Specifications, BasePrice")] Aircraft aircraft)
        {
            if (!ModelState.IsValid)
            {
                return View(aircraft);
            }
            await _service.UpdateAsync(id, aircraft);
            return RedirectToAction(nameof(Index));
        }

        //Get: Aircraft/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var aircraftDetails = await _service.GetByIdAsync(id);

            if (aircraftDetails == null) { return View("NotFound"); }
            return View(aircraftDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aircraftDetails = await _service.GetByIdAsync(id);
            if (aircraftDetails == null) { return View("NotFound"); }

            await _service.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
