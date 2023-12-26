namespace MTGCardFile.Models
{
    public class LandCard
    {
        public string LandName { get; set; }
        public List<string> LandType { get; set; }        
        public bool DualLand { get; set; }
        public string LandBio { get; set; }

        public LandCard() { }
        public LandCard(string landName, List<string> landType, bool dualLand, string landBio)
        {
            LandName = landName;
            LandType = landType;
            DualLand = dualLand;
            LandBio = landBio;
        }
    }
}
