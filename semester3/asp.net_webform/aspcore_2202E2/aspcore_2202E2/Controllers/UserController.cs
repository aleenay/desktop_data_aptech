using Microsoft.AspNetCore.Mvc;

namespace aspcore_2202E2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
