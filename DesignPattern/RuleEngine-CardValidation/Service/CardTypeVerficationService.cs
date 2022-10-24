using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using DesignPattern.RuleEngine_CardValidation.Rule.Interface;

namespace DesignPattern.RuleEngine_CardValidation.Service
{
    public class CardTypeVerficationService
    {
        private readonly GenerateCardRuleService _cardRuleService;
        private readonly IEnumerable<IRule?> _rules;

        public CardTypeVerficationService()
        {
            _cardRuleService = new GenerateCardRuleService();
            _rules = _cardRuleService.GetRules();
        }

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

            return _rules.FirstOrDefault(x => x.IsCardValid(cardNumber))!.GetCardType();
        }


        private bool IsValidLuhn(string digit)
            => digit.All(char.IsDigit) && digit.Reverse()
                .Select(c => c - 48)
                .Select((dig, i) => i % 2 == 0 ? dig : ((dig *= 2) <= 9 ? dig : dig - 9))
                .Sum() % 10 == 0;
    }
}
