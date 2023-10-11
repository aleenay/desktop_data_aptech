using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using testingproject1.Models;

namespace testingproject1.Controllers
{
    public class UserController : Controller
    {

        static List<form> ContactList = new List<form>();


       


        public IActionResult Index()
        {
            List < empClass > Objemp = new List<empClass>
            {
                new empClass{id = 101, name = "tooba"},
                new empClass{id = 102, name = "ahmed"},
                new empClass{id = 103, name = "ebad"},
                new empClass{id = 104, name = "dania"},

            };
            ViewData["emplist"] = Objemp;

            //return View(ContactList);
            return View();

        }
        public IActionResult About()
        {
            var objdemo = new List<DemoClass>
            {
                new DemoClass{id = 101, name ="ali" },
                new DemoClass{id = 102, name ="ayna" },
                new DemoClass{id = 103, name ="aliyan" },
                new DemoClass{id = 104, name ="aliya" },

            };
          
            ViewData["DemoList"] = objdemo;
            return View();

        }

        public IActionResult contactus()
        {
            
            return View();

        }

        [HttpPost]
        public IActionResult contactus(form fdata)
        {
            ViewData["name"] = fdata.Name;

            return View();

        }
        //public IActionResult contactus(form fdata)
        //{
        //    ContactList.Add(fdata);

        //    return RedirectToAction("Index");

        //}
    }
}
