namespace MTGCardFile.Models
{
    public class CardObject
    {
        public string CardName { get; set; }
        public string SetName { get; set; }
        public List<string> ManaType { get; set; }
        public int CastingCost { get; set; }
        public string CardBio { get; set; }

        public CardObject(string cardName, string setName, List<string> manaType, int castingCost, string cardBio)
        {
            CardName = cardName;
            SetName = setName;
            ManaType = manaType;
            CastingCost = castingCost;
            CardBio = cardBio;
        }
    }
}
