using asp_core_mvc_2207B2.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_core_mvc_2207B2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(user objUser)
        {
            ViewBag.username = objUser.name;
            return View();
        }
    }
}
