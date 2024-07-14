using Microsoft.AspNetCore.Mvc;
using RaythosAerospace.Data;
using RaythosAerospace.Data.Services;

namespace RaythosAerospace.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
    }
}
