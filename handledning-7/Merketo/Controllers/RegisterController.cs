using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
