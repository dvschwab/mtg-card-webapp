namespace MTGCardFile.Models
{
    public class CreatureCard : CardObject
    {
        public string SpeciesCard { get; set; }
        public List<string> SpecialAbilities { get; set; }

        public int SpeciesPower { get; set; }

        public int SpeciesToughness { get; set; }

        public bool LegendaryCreature { get; set; }

        public CreatureCard() { }

        public CreatureCard(string speciesCard, List<string> specialAbilities, int speciesPower, int speciesToughness, bool legendaryCreature) : base()
        {

            SpeciesCard = speciesCard;
            SpecialAbilities = specialAbilities;
            SpeciesPower = speciesPower;
            SpeciesToughness = speciesToughness;
            LegendaryCreature = legendaryCreature;
        }
    }
}
