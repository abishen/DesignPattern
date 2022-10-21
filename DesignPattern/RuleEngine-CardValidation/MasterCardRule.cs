using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public class MasterCardRule : IRule
    {
        public bool IsCardValid(string cardNumber)
            => (cardNumber.Length == 16 && Regex.IsMatch(cardNumber, "^(51|52|53|54|55)"));

        public CardType GetCardType()
            => CardType.MasterCard;
    }
}
