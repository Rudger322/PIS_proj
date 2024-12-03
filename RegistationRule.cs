using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class RegistationRule : IRule
    {
        public List<MapPoint> Apply(User user)
        {
            if (user == null)
            {
                return new List<MapPoint> { new MapPoint("Для просмотра дорожной карты необходимо зарегистрироваться.") };
            }
            return new List<MapPoint>();
        }
    }
}
