using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeatherApp_Sakshi_WebDev.Models;

namespace WeatherApp_Sakshi_WebDev.Controllers
{
    // This is the HomeController class responsible for handling various actions and views
    // Author: Sakshi
    // Student Number: A00262877
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor to inject the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for the Index page
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the About page
        public IActionResult About()
        {
            return View();
        }

        // Action method for the Privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action method for handling errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Passes an ErrorViewModel to the Error view
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
