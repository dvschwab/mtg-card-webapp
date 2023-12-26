namespace MTGCardFile.Models
{
    public class InstantCard : CardObject
    {
        public string CardEffect {  get; set; }
        public InstantCard() { }

        public InstantCard(string cardEffect) {  CardEffect = cardEffect; }
    }
}
