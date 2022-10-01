using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web65.Models;

namespace web65.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons = new List<Person>();
        public IActionResult Index()
        {
            return View(persons);
        }
        //[Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Person person)
        {
            persons.Add(person);
            //return View("Index", persons); // giu nguyen url, nhung gui lai request (add them) khi f5 (bi duplicate.)
            return RedirectToAction("Index", persons);//thay doi url va k bi duplicate.
        }
        public IActionResult Delete(int id)
        {
            persons.RemoveAt(id);
            return RedirectToAction("Index", persons);
        }
    }
}
