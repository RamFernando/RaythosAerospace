using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
