using System.Text.RegularExpressions;
using DesignPattern.RuleEngine_CardValidation.Rule.Interface;

namespace DesignPattern.RuleEngine_CardValidation.Rule
{
    public class VisaRule : IRule
    {
        private const string CardFirstDigitPattern = "^(51|52|53|54|55)";
        private const int CardNumberLenght = 16;
        private const int CardNumberLenghtnd2 = 13;
        public bool IsCardValid(string cardNumber)
        => (cardNumber.Length == 16 || cardNumber.Length == 13 && Regex.IsMatch(cardNumber, "^(4)"));
        

        public CardType GetCardType()
        {
            return CardType.VISA;
        }
    }
}
