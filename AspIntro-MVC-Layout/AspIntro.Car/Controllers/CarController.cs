using AspIntro.Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Car.Controllers
{
    public class CarController : Controller
    {
        private List<Carr> cars = new List<Carr>
        {
            new Carr { Id = 1, Name = "Corolla", ModelId = 1, Color = "Red" },
            new Carr { Id = 2, Name = "Focus", ModelId = 2, Color = "Blue" },
            new Carr { Id = 3, Name = "Golf", ModelId = 3, Color = "Black" },
            new Carr { Id = 4, Name = "Elantra", ModelId = 4, Color = "White" },
            new Carr { Id = 5, Name = "Punto", ModelId = 5, Color = "Silver" }
        };
        public IActionResult Index(int? modelId)
        {
            if (modelId is null)
            {
                return View(cars);
            }
            return View(cars.Where(m => m.ModelId == modelId).ToList());
        }
        public IActionResult Detail(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}
