using Microsoft.AspNetCore.Mvc;
using MTGCardFile.Models;

namespace MTGCardFile.Controllers
{
    public class CardDisplay : Controller
    {
        public IActionResult ShowCard()
        {
            CreatureCard barbaryApes = new CreatureCard("Barbary Apes", "Revised", new List<CardObject.ManaTypes> {}, 3, "Damn Dirty Apes!", "Ape", new List<string> { "None" }, 2, 2, false);

            ViewBag.CreatureName = barbaryApes.CardName;
            
            return View();
        }
    }
}
