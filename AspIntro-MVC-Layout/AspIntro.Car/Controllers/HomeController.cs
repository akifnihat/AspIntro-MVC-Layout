using AspIntro.Car.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspIntro.Car.Controllers
{
    public class HomeController : Controller
    {
         private List<Marka> _markas = new List<Marka> 
         { 
            new Marka { Id = 1, Name = "Toyota", Country = "Japan" },
            new Marka { Id = 2, Name = "Ford", Country = "USA" },
            new Marka { Id = 3, Name = "Volkswagen", Country = "Germany" },
            new Marka { Id = 4, Name = "Hyundai", Country = "South Korea" },
            new Marka { Id = 5, Name = "Fiat", Country = "Italy" }
         };
        public IActionResult Index(int? markaId)
        {
            if (markaId is null)
            {
                return View(_markas);
            }
            return View(_markas.Where(m => m.Id == markaId).ToList());
        }
    }
}
