namespace MTGCardFile.Models
{
    public class InstantCard { 
        public string CardEffect {  get; set; }

        public InstantCard(string cardEffect) {  CardEffect = cardEffect; }
    }
}
