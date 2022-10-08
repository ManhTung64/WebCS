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
    }
}
