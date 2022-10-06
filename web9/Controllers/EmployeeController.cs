using Microsoft.AspNetCore.Mvc;
using web9.Models;

namespace web9.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View("Result", employee);
            }
            return View(employee);
        }
        public IActionResult Result(Employee employee)
        {
            return View(employee);
        }
    }
}
