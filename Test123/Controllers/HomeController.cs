using Microsoft.AspNetCore.Mvc;

namespace Test123.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}