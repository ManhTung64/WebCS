using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web11.Data;

namespace web11.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext context;
        public StudentController(ApplicationDbContext context)
        {
            this.context = context;
        }
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
        public IActionResult Edit(int? id)
        {
            return View("Index");
        }
        public IActionResult Add(int? id)
        {
            return View("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)return NotFound();
            var student = context.students.Find(id);
            context.students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
