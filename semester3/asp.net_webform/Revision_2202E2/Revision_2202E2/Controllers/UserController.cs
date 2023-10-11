using Microsoft.AspNetCore.Mvc;
using Revision_2202E2.Models;

namespace Revision_2202E2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult service()
        {
            ViewData["data1"] = "View data";
            TempData["data2"] = "temp data";
           ViewBag.data3 = "view bag";


            //ViewBag.std_age = 20;
            //string[] std_list = { "Rawaha", "Bilal", "Hatim" };
            //ViewBag.stdlist = std_list;


            // view data viewbag tempdata
            //ViewData["username"] = "Huzaifa";
            //ViewData["age"] = 20;
            //string[] std_list = { "Rawaha", "Bilal", "Hatim" };
            //ViewData["stdlist"] = std_list;

            return View("servicepage");
        }
        public IActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactForm(User objuser)
        {
            ViewData["username"] = objuser.name;

            return View();
        }

    }
}
