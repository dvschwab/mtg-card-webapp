using Microsoft.Win32.SafeHandles;
using MTGCardFile.Models;

namespace MTGCardFile.Data
{
    public class CardBox : FileStream
    {
        public string Filename { get; set; }
        public string? ImageFile { get; set; }
        public CardBox(string filename) : base(filename, FileMode.CreateNew) { }

        public CardBox(string filename, string imageFile) : base(filename, FileMode.CreateNew)
        {
            ImageFile = imageFile;
        }

        public void AddCard (CardObject Card)
        {
            using(FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Write))
            {
                foreach(byte ch in Card.CardName)
                {
                    fs.WriteByte(ch);
                }
            }
        }

        public void Package(string filename)
        {
            // Packages the CardBox files together as a compressed file
        }
    }
}
