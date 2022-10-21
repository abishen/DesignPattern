using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public interface IRule
    {
        CardType GetCardType();
        bool IsCardValid(string cardNumber);


    }
}
