using Microsoft.AspNetCore.Mvc;

namespace WebForm.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Authentication(string email, string password)
        {
            if (email == "admin" && password == "admin") ViewBag.Result = true;
            else ViewBag.Result = false;
            return View();
        }
    }
}
