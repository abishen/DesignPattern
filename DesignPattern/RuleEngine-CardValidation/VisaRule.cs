using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public class VisaRule : IRule
    {
        public bool IsCardValid(string cardNumber)
        => (cardNumber.Length == 16 || cardNumber.Length == 13 && Regex.IsMatch(cardNumber, "^(4)"));
        

        public CardType GetCardType()
        {
            return CardType.VISA;
        }
    }
}
