namespace MTGCardFile.Models
{
    public class EnchantmentCard { 
        public string EnchantType { get; set; }

        public string EnchantEffect { get; set; }

        public EnchantmentCard(string enchantType, string enchantEffect) { 
            EnchantType = enchantType;
            EnchantEffect = enchantEffect;
        }
    }
}
