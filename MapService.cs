using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MapService
    {
        Rules rules;
        public List<MapPoint> GetMap(User user)
        {
            return rules.checkRules(user);
        }
        public MapService(Rules rules)
        {
            this.rules = rules;
        }
    }
}
