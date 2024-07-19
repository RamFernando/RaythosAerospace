using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
