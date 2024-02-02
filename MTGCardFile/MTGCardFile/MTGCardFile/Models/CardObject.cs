using System.Text.Json;

namespace MTGCardFile.Models
{
    public class CardObject
    {
        public string CardName { get; set; }
        public string SetName { get; set; }
        public List<ManaTypes> ManaType { get; set; }
        public int CastingCost { get; set; }
        public string CardBio { get; set; }

        public CardObject(string cardName, string setName, List<ManaTypes> manaType, int castingCost, string cardBio)
        {
            CardName = cardName;
            SetName = setName;
            ManaType = manaType;
            CastingCost = castingCost;
            CardBio = cardBio;
        }

        public enum ManaTypes
        {
            FOREST,
            MOUNTAIN,
            ISLAND,
            PLAIN,
            SWAMP
        }

        public string toJson() 
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
