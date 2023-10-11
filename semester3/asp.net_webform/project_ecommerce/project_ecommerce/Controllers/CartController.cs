using Microsoft.AspNetCore.Mvc;

namespace project_ecommerce.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
