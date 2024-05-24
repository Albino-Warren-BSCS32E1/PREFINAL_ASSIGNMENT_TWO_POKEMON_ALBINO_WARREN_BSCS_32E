using Microsoft.AspNetCore.Mvc;

namespace PREFINAL_ASSIGNMENT_TWO_POKEMON_ALBINO_WARREN_BSCS_32E.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
