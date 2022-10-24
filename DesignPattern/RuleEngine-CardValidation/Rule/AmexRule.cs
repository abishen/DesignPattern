using DesignPattern.RuleEngine_CardValidation.Rule.Interface;

namespace DesignPattern.RuleEngine_CardValidation.Rule
{
    public class AmexRule : IRule
    {
        private const string CardFirstDigitPattern = "^(34|37)";
        private const int CardNumberLenght = 15;
        public bool IsCardValid(string cardNumber)
        =>(Ex.IsValidBy(cardNumber,CardNumberLenght,CardFirstDigitPattern));

        public CardType GetCardType()
            => CardType.AMEX;
    }
}
