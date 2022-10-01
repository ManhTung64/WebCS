using Microsoft.AspNetCore.Mvc;

namespace WebForm.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Input()
        {
            return View();
        }
        public IActionResult Output(string name, int age, string image)
        {
            ViewData["Name"] = name;
            ViewBag.Age = age;
            ViewBag.Image = image;
            return View();
        }
    }
}
