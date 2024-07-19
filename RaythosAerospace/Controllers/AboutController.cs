using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
