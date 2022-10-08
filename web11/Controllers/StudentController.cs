using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web11.Data;
using web11.Models;

namespace web11.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext context;
        public StudentController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var data = context.students.ToList();
            return View(data);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var product = context.students.FirstOrDefault(student => student.Id == id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            return View(context.students.Find(id));
        }
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                context.students.Update(student);
                context.SaveChanges();
                TempData["mess"] = "Thanh cong roi nhe em zai";
                return RedirectToAction("Index");
            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                context.students.Add(student);
                context.SaveChanges();
                TempData["mess"] = "Thanh cong roi nhe em zai";
                return RedirectToAction("Index");
            }
            return View(student);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)return NotFound();
            var student = context.students.Find(id);
            context.students.Remove(student);
            context.SaveChanges();
            TempData["mess"] = "Thanh cong roi nhe em zai";
            //su dung tempdata de gui du lieu ve view neu use redirect  
            return RedirectToAction("Index");
        }
    }
}
