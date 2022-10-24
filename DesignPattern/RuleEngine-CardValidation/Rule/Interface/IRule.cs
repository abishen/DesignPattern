namespace DesignPattern.RuleEngine_CardValidation.Rule.Interface
{
    public interface IRule
    {
        CardType GetCardType();
        bool IsCardValid(string cardNumber);


    }
}
