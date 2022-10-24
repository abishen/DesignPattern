using DesignPattern.RuleEngine_CardValidation.Rule.Interface;

namespace DesignPattern.RuleEngine_CardValidation.Rule
{
    public class MasterCardRule : IRule
    {
        private const string CardFirstDigitPattern = "^(51|52|53|54|55)";
        private const int CardNumberLenght = 16;
        public bool IsCardValid(string cardNumber)
            => (Ex.IsValidBy(cardNumber,CardNumberLenght,CardFirstDigitPattern));

        public CardType GetCardType()
            => CardType.MasterCard;
    }
}
