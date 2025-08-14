using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to the Home Page!";
            ViewBag.Title = "Home Page";
            TempData["Notification"] = "This is a temporary notification message.";

            return View();
        }
    }
}
