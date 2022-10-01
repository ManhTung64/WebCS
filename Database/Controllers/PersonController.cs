using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web6.Models;

namespace web6.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons = new List<Person>();
        public IActionResult Index()
        {
            return View(persons);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Person person)
        {
            persons.Add(person);
            return View("Index", persons);
            // return RedirectToAction("Index");
        }
    }
}
