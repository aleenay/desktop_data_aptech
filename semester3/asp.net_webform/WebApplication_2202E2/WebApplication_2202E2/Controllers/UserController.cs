using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication_2202E2.Models;

namespace WebApplication_2202E2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var ObjUserList = new List<User>
            {
                new User { name  = "Naveera" , email = "Naveera@gmail.com" , phoneno = 0321765765},
                new User { name  = "Tooba" , email = "T@gmail.com" , phoneno = 0327687765},
                new User { name  = "Bilal" , email = "Bilal@gmail.com" , phoneno = 0333365765},
               

            };
            ViewData["UserList"] = ObjUserList;
            return View();
        }
        public IActionResult RegForm()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult RegForm(UserForm objUserForm)
        {
            ViewData["user_name"] = objUserForm.Name;
            return View();
        }
    }
}
