using System.Text.Json;

namespace MTGCardFile.Models
{
    public class CardObject
    {
        public string CardName { get; set; }
        public string SetName { get; set; }
        public List<ManaType> ManaType { get; set; }
        public int CastingCost { get; set; }
        public string CardBio { get; set; }

        public CardObject(string cardName, string setName, List<ManaType> manaType, int castingCost, string cardBio)
        {
            CardName = cardName;
            SetName = setName;
            ManaType = manaType;
            CastingCost = castingCost;
            CardBio = cardBio;
        }

        public string toJson() 
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
