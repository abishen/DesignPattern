using System.ComponentModel.DataAnnotations;
using DesignPattern.RuleEngine_CardValidation;
using NUnit.Framework;

namespace DesignPattern.UnitTest
{
    public class Tests
    {
        private CardTypeVerficationService _cardTypeVerficationService;
        [SetUp]
        public void Setup()
        {
            _cardTypeVerficationService = new CardTypeVerficationService();
        }

        [TestCase("4263982640269299",ExpectedResult = CardType.VISA, Description = "Verify Visa Card Number")]
        [TestCase("374245455400126", ExpectedResult = CardType.AMEX, Description = "Verify Amex Card Number")]
        [TestCase("6011000991300009", ExpectedResult = CardType.Discover, Description = "Verify Discover Card Number")]
        [TestCase("5425233430109903", ExpectedResult = CardType.MasterCard, Description = "Verify Mastercard Card Number")]
        [TestCase("", ExpectedResult = CardType.Unknown, Description = "Verify Incorrect Card Number")]
        [TestCase(null, ExpectedResult = CardType.Unknown, Description = "Verify Incorrect Card Number")]
        public CardType VerifyCardType(string cardNumber)
            => _cardTypeVerficationService.GetCardTypeVerification(cardNumber);


        [TestCase("4400000")]
        public void VerifyCardTypeThrow(string cardNumber)
        {
            var ex = Assert.Throws<ValidationException>(() =>
                _cardTypeVerficationService.GetCardTypeVerification(cardNumber));
            Assert.AreEqual("Card Number is Invalid", ex.Message);
        }
    }
}