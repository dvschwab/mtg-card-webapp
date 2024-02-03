namespace MTGCardFile.Models
{
    public class CreatureCard : CardObject
    {
        public string Species { get; set; }
        public List<string> SpecialAbilities { get; set; }

        public int Power { get; set; }

        public int Toughness { get; set; }

        public bool LegendaryCreature { get; set; }

        public CreatureCard(string cardName, string setName, List<ManaType> manaType, int castingCost, string cardBio, string species, List<string> specialAbilities, int power, int toughness, bool legendaryCreature) : base(cardName, setName, manaType, castingCost, cardBio)
        {

            Species = species;
            SpecialAbilities = specialAbilities;
            Power = power;
            Toughness = toughness;
            LegendaryCreature = legendaryCreature;
        }
    }
}
