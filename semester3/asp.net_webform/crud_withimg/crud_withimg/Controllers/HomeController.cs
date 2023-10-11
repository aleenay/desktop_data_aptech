using crud_withimg.Data;
using crud_withimg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crud_withimg.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly db_2202f2Context db_context;

        public HomeController(db_2202f2Context context)
        {
            db_context = context;
        }

        public IActionResult Index()
        {
           // HttpContext.Session.SetInt32("user", 123);
            HttpContext.Session.SetString("user", "ali");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.user_name = HttpContext.Session.GetString("user");
            return View();
        }


        public IActionResult Login()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Login(TblUser user)
        {
            var userdata = db_context.TblUsers.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
        //    var x = userdata.Email;
            if (userdata != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
             ViewBag.datanotfound = "Login Failed !";
            return View();

            }
            //var myuser = _context.TblUsers.Where(x => x.Email == user.Email && x.Password == user.Password ).FirstOrDefault();
            //if(myuser != null)
            //{
            //return RedirectToAction("Dashboard");

            //}
        }
        public IActionResult Dashboard()
        {

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}