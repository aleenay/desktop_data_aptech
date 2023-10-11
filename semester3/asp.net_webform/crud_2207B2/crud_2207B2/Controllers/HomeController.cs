using crud_2207B2.Data;
using crud_2207B2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crud_2207B2.Controllers
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
            HttpContext.Session.SetString("user_name", "Huzaifa khan");
            return View();
        }

        public IActionResult Privacy()
        {
           ViewBag.u_name =  HttpContext.Session.GetString("user_name");
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(TblUser objUser)
        {
          
            var userdata = db_context.TblUsers.Where(x => x.Email == objUser.Email && x.Password == objUser.Password).FirstOrDefault();
            if (userdata != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {

            ViewBag.loginfailed = "login failed";
            return View();
            }
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