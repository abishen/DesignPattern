using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public class DiscoverRule : IRule
    {
        public bool IsCardValid(string cardNumber)
        => (cardNumber.Length == 16 && Regex.IsMatch(cardNumber,"^(6011)"));

        public CardType GetCardType() 
            => CardType.Discover;
    }
}
