using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using testingproject1.Models;

namespace testingproject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["data1"] = "demo view data";
            ViewData["data2"] = 25;
            ViewData["data3"] = DateTime.Now.ToShortDateString();
            string[] arr = { "Ali", "ahmed" };
            ViewData["data4"] = arr;
            // view bag
            ViewBag.data5 = "demo view bag";
            ViewBag.data6 = arr;
            // tempdata
            TempData["tempdata"] = "demo_TempData";
            TempData.Keep();
            return View();
        }

        public IActionResult Privacy()
        {
            var ObjStd = new List<StudentModel>
            {
               new StudentModel {rollno= 101 , name = "abbas" , age = 20 },
               new StudentModel {rollno= 102 , name = "ahmed" , age = 24 },
               new StudentModel {rollno= 103 , name = "fatima" , age = 25 },
               new StudentModel {rollno= 104 , name = "muhammad" , age = 22 }

            };


            ViewData["stdList"] = ObjStd;
            TempData.Keep("tempdata");

            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("tempdata");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}