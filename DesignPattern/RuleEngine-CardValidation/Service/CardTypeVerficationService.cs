using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public class CardTypeVerficationService
    {

        public CardType GetCardTypeVerification(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
            {
                return CardType.Unknown;
            }

            if (!IsValidLuhn(cardNumber))
            {
                throw new ValidationException("Card Number is Invalid");
            }
            
            var ruleType = typeof(IRule);
            IEnumerable<IRule?> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule);

            return rules.FirstOrDefault(x => x.IsCardValid(cardNumber))!.GetCardType();
        }


        private bool IsValidLuhn(string digit)
            => digit.All(char.IsDigit) && digit.Reverse()
                .Select(c => c - 48)
                .Select((dig, i) => i % 2 == 0 ? dig : ((dig *= 2) <= 9 ? dig : dig - 9))
                .Sum() % 10 == 0;
    }
}
