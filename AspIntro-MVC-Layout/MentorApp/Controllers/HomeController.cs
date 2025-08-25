using MentorApp.Data;
using MentorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MentorApp.Controllers
{
    public class HomeController(Mentordbcontext mentordbcontext) : Controller
    {
        public IActionResult Index()
        {
            var list = mentordbcontext.Atributess.ToList();
            return View(list);
        }

    }
}
