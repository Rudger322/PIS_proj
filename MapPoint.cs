using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MapPoint
    {
        public MapPoint(string desc)
        {
            Description = desc;
        }
        public string Description;

        public bool isApplicable(User user)
        {
            return user != null;
        }

    }
}
