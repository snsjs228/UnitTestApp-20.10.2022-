using Microsoft.AspNetCore.Mvc;


namespace UnitTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello!";
            return View("Index");
        }
       
    }
}
