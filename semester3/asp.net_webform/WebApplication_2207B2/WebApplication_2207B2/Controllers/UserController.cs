using Microsoft.AspNetCore.Mvc;
using WebApplication_2207B2.Models;

namespace WebApplication_2207B2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var ObjUser = new List<User>
            {
              new User { id = 101 , age = 20 ,name = "Huzaifa" },
              new User { id = 102 , age = 27 ,name = "Sarim" },
              new User { id = 103 , age = 26 ,name = "Zoahir" },
              new User { id = 104 , age = 21 ,name = "Mesum" },
              new User { id = 105 , age = 23 ,name = "Arshaman" },

            };
            ViewData["StdList"] = ObjUser;
            return View();
        }
        public IActionResult About()
        {
            return View("Aboutus");
        }
        public IActionResult UserForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserForm(std objstd)
        {
            ViewData["username"] = objstd.name;
            return View();
        }
    }
}
