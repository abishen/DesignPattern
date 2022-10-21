using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public enum CardType : byte
    {
        AMEX  = 1,
        VISA,
        Discover,
        MasterCard,
        Unknown
            
    }
}
