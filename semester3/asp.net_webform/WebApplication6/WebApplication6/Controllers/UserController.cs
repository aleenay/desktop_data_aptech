using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
