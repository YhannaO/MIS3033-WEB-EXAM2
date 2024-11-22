using Microsoft.AspNetCore.Mvc;
using DogApp.Models; 

namespace DogApp.Controllers 
{
    public class AboutController : Controller
    {
        public IActionResult Me()
        {
            var aboutModel = new AboutModel
            {
                FullName = "Yhanna Osborn",
                ExpectedGraduation = "Fall 2024",
                HardestConcept = "API Integration and Routing",
                EasiestConcept = "HTML and CSS",
                ImageUrl = "https://via.placeholder.com/150",
                FavoriteFood = "Pumpkin Pie",
                FavoriteFoodImageUrl = "https://via.placeholder.com/150" 
            };

            return View(aboutModel);
        }
    }
}

