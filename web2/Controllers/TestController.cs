using Microsoft.AspNetCore.Mvc;

namespace web2.Controllers
{
    public class TestController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HaNoi()
        {
            return View();
        }
        public IActionResult DN()
        {
            return View();
        }
        public IActionResult CT()
        {
            return View();
        }
    }
}
