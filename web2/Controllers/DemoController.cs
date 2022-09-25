using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace web2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Demo()
        {
            return View();
        }
        public IActionResult TenGiCungDuoc()
        {
            var year = DateTime.Now.Year;
            var yob = 2002;
            List<string> names = new List<string>()
            {
                "A","b","c"
            };
            ViewBag.Names = names;
            var age = year - yob;
            ViewData["Age"] = age;
            ViewData["year"] = year;
            return View();
        }
    }
}
