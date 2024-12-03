using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class PolicyRule : IRule
    {
        private readonly string[] _countriesRequiringPolicy =
        {
            "Азербайджан", "Таджикистан", "Узбекистан", "Молдова",
            "Украина", "Киргизия", "Казахстан", "Армения"
        };

        public List<MapPoint> Apply(User user)
        {
            if (user.Purpose == Purpose.Работа &&
                _countriesRequiringPolicy.Contains(user.Citizenship) &&
                user.Policy == "Нет")
            {
                return new List<MapPoint>
            {
                new MapPoint("- Для трудоустройства вам нужно оформить полис ОМС или ДМС. Вы можете оформить его в любой страховой компании.\n")
            };
            }
            return new List<MapPoint>();
        }
    }
}
