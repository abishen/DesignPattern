using DesignPattern.RuleEngine_CardValidation.Rule.Interface;
using System;
using System ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RuleEngine_CardValidation.Service
{
    public class GenerateCardRuleService
    {
        public  IEnumerable<IRule?> GetRules()
        {
            var ruleType = typeof(IRule);
            return GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule);
        }

    }
}
