using Microsoft.AspNetCore.Mvc;
using miniproject_2202f2.Data;
using miniproject_2202f2.Models;
using System.Diagnostics;

namespace miniproject_2202f2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly db_2202f2Context _context;
        // constructor
        public HomeController(db_2202f2Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HttpContext.Session.SetString("username", "warda");
            return View();
        }

        public IActionResult Privacy()
        {
          ViewBag.u_name =   HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult Login()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Login(TblUser objuser)
        {
            var userdata = _context.TblUsers.Where(x => x.Email == objuser.Email && x.Password == objuser.Password).FirstOrDefault();
            if(userdata != null)
            {
                var x = userdata.Email;
                HttpContext.Session.SetString("user_email", x);
                return RedirectToAction("Dashboard");
            }


            return View();
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