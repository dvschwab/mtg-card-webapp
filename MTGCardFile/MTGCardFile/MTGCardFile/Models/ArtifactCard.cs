namespace MTGCardFile.Models
{
    public class ArtifactCard : CardObject
    {
        public string ArtifactType { get; set; }
        public string ArtifactEffect { get; set; }

        public ArtifactCard() { }
        public ArtifactCard(string artifactType, string artifactEffect) : base()
        {
            ArtifactType = artifactType;
            ArtifactEffect = artifactEffect;
        }
    }
}
