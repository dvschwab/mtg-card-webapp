using Microsoft.AspNetCore.Mvc;
using MTGCardFile.Models;

namespace MTGCardFile.Controllers
{
    public class CardDisplay : Controller
    {
        public IActionResult Index()
        {
            CreatureCard barbaryApes = new CreatureCard("Barbary Apes", "Revised", new List<string> { "2 Forest" }, 3, "Damn Dirty Apes!", "Ape", new List<string> { "None" }, 2, 2, false);
            
            return View();
        }
    }
}
