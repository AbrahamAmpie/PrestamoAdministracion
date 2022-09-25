using Microsoft.AspNetCore.Mvc;

namespace administracionPrestamo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
