using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
