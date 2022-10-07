using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web10.Data;

namespace web10.Controllers
{
    public class BillController : Controller
    {
        private readonly ApplicationDbContext context;
        public BillController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var bills = context.bill.ToList();
            return View(bills);
        }
    }
}
