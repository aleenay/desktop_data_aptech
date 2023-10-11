using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApp1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
