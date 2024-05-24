using Microsoft.AspNetCore.Mvc;
using PREFINAL_ASSIGNMENT_TWO_POKEMON_ALBINO_WARREN_BSCS_32E.Models;
using System.Diagnostics;

namespace PREFINAL_ASSIGNMENT_TWO_POKEMON_ALBINO_WARREN_BSCS_32E.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
