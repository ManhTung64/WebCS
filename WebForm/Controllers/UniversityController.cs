using Microsoft.AspNetCore.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class UniversityController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(University data)
        {

            return View("Result", data);
        }
    }
}
