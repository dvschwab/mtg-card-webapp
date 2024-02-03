namespace MTGCardFile.Models
{
    public class ManaType
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public ManaType(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
