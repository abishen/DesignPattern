using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public class AmexRule : IRule
    {
        public bool IsCardValid(string cardNumber)
        => (cardNumber.Length == 15 && Regex.IsMatch(cardNumber,"^(34|37)"));

        public CardType GetCardType()
            => CardType.AMEX;
    }
}
