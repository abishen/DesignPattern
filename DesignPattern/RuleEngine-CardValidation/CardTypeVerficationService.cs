using System;
using System.Collections.Generic;
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

            var ruleType = typeof(IRule);
            IEnumerable<IRule?> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule);

            return rules.FirstOrDefault(x => x.IsCardValid(cardNumber))!.GetCardType();
        }

    }
}
