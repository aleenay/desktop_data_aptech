using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_2207B2.Models;

namespace WebApplication_2207B2.Controllers
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
            ViewData["data1"] = "View Data";
            ViewBag.std_name = "View Bag";
            TempData["stdname"] = "Temp Data";
            TempData.Keep();

            return View();

            // ViewData , ViewBag , TempData
            //ViewData["data1"] = "Zohair";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = false;
            //string[] arr = { "Ali", "Ahmed", "Huzaifa" };

            //ViewData["stdlist"] = arr;

            //ViewBag.stdname = "Huzaifa";
            //ViewBag.stdage = 20;
            //string[] arr = { "Ali", "Ahmed", "Huzaifa" };
            //ViewBag.stdlist = arr;
            //TempData["stdage"] = 20;
            //ViewData["data1"] = "View Data";
            //ViewBag.std_name = "View Bag";
            //TempData["stdname"] = "Temp Data";
            //TempData.Keep();



        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("stdname");
            //TempData.Keep("stdname");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}