namespace MTGCardFile.Models
{
    public class ArtifactCard
    {
        public string ArtifactType { get; set; }
        public string ArtifactEffect { get; set; }

        public ArtifactCard(string artifactType, string artifactEffect)
        {
        
            ArtifactType = artifactType;
            ArtifactEffect = artifactEffect;
        }
    }
}
