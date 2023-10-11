using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_2202E2.Models;

namespace WebApplication_2202E2.Controllers
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
            // ViewData // ViewBag //TempData
            //ViewData["data1"] = "Huzaifa";
            //ViewData["data2"] = 25;
            //string[] arr = { "Ahmed", "rawaha", "bilal" };
            //ViewData["stdList"] = arr;

            //ViewBag.data1 = "Hatim Tai";
            //ViewBag.data2 = "Hani";
            //ViewBag.data3 = 101;
            //ViewBag.data4 = true;

            //string[] arr = { "Ahmed", "rawaha", "bilal" };
            //ViewBag.stdlist = arr;
            ViewData["Message"] = "This is View Data";
            ViewBag.data1 = "This is View Bag";

            TempData["demo1"] = "this is Temp data";
            TempData.Keep();

            return View();
        }

        public IActionResult Privacy()
        {
            TempData.Keep("demo1");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}