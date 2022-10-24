using DesignPattern.RuleEngine_CardValidation.Rule.Interface;

namespace DesignPattern.RuleEngine_CardValidation.Rule
{
    public class DiscoverRule : IRule
    {
        private const string CardFirstDigitPattern = "^(6011)";
        private const int CardNumberLenght = 16;
        public bool IsCardValid(string cardNumber)
        => (Ex.IsValidBy(cardNumber,CardNumberLenght,CardFirstDigitPattern));

        public CardType GetCardType() 
            => CardType.Discover;
    }
}
