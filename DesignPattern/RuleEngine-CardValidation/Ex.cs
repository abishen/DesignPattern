using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation
{
    public static class Ex
    {
        public static bool IsValidBy(string cardNumber, int fixedLenght, string regx)
            => (cardNumber.Length == fixedLenght && Regex.IsMatch(cardNumber, regx));

    }
}
