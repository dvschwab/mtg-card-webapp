namespace MTGCardFile.Models
{
    public class EnchantmentCard : CardObject
    {
        public string EnchantType { get; set; }

        public string EnchantEffect { get; set; }

        public EnchantmentCard() { }
        public EnchantmentCard(string enchantType, string enchantEffect) : base()
        {
            EnchantType = enchantType;
            EnchantEffect = enchantEffect;
        }
    }
}
