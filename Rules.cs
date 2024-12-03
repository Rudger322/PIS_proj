

using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public class Rules
    {
        private readonly List<IRule> _rules;

        public Rules()
        {
            _rules = new List<IRule>
        {
            new RegistationRule(),
            new PolicyRule(),
            new MedicalCheckRule()
        };
        }

        public List<MapPoint> checkRules(User user)
        {
            var roadmap = new List<MapPoint> { new MapPoint("Ваша дорожная карта:\n") };

            foreach (var rule in _rules)
            {
                roadmap.AddRange(rule.Apply(user));
            }

            return roadmap;
        }
    }
}
