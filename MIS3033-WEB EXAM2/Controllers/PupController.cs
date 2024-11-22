using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogApp.Controllers // Replace DogApp with your project name
{
    public class PupController : Controller
    {
        // Action for /Pup/Scoop
        public async Task<IActionResult> Scoop()
        {
            string apiUrl = "https://dog-api.kinduff.com/api/facts";
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(apiUrl);

            ViewBag.DogFact = response;
            return View();
        }

        // Action for /Pup/RandPic
        public IActionResult RandPic()
        {
            string randomImageUrl = "https://place.dog/500/300";
            ViewBag.DogImage = randomImageUrl;
            return View();
        }

        // Action for /Pup
        public async Task<IActionResult> Index()
        {
            string factApi = "https://dog-api.kinduff.com/api/facts";
            using var httpClient = new HttpClient();
            var factResponse = await httpClient.GetStringAsync(factApi);

            string randomImageUrl = "https://place.dog/500/300";

            ViewBag.DogFact = factResponse;
            ViewBag.DogImage = randomImageUrl;

            return View();
        }
    }
}
