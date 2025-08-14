using AspIntro.Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Car.Controllers
{
    public class ModelController : Controller
    {
        private List<Model> models = new List<Model>
        {
            new Model { Id = 1, Name = "Sedan" },
            new Model { Id = 2, Name = "Hatchback" },
            new Model { Id = 3, Name = "SUV" },
            new Model { Id = 4, Name = "Coupe" },
            new Model { Id = 5, Name = "Convertible" }
        };
        public IActionResult Index(int? modelId)
        {
            if (modelId is null)
            {
                return View(models);
            }
            return View(models.Where(m => m.Id == modelId).ToList());
        }
    }
}
