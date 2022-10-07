using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web10.Data;

namespace web10.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // select * from product, read function
        public IActionResult Index()
        {
            var products = context.product.ToList();
            return View(products);
        }
        // select * from product where ..., read function
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var product = context.product.FirstOrDefault(pro => pro.Id == id);
            return View(product);
        }
    }
}
