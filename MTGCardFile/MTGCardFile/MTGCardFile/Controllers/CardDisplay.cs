using Microsoft.AspNetCore.Mvc;
using MTGCardFile.Models;

namespace MTGCardFile.Controllers
{
    public class CardDisplay : Controller
    {
        public IActionResult ShowCard()
        {

            List<ManaType> newCardMana = new List<ManaType>();
            ManaType Foreest = new ManaType("Forest", "");
            ManaType Colorless = new ManaType("Colorless", "");
            newCardMana.Add(Foreest);
            newCardMana.Add(Colorless);

            CardObject newCard = new CardObject("Scryb Sprites", "Revised", newCardMana, 2, "Flying elves are back!");
            string jsonCard = newCard.toJson();
            
            return View();
        }
    }
}
