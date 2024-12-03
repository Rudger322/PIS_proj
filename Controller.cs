using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Controller
    {
        private Service service;
        private MapService mapservice;
        public Controller()
        {
            service = new Service(new Repository());
            mapservice = new MapService(new Rules());
        }


        public List<string> getRelevantPurpose()
        {
            return service.getRelevantPurose();
        }
        public List<string> getContries()
        {
            return service.getCountries();
        }
        public void addInfo(string citizenship, Purpose purpose, DateTime dateOfEntry, string policy, bool IsLongStay)
        {
            service.addInfo(new User(citizenship, purpose, dateOfEntry, policy, IsLongStay));
        }
        public List<string> seeMap()
        {
            List<MapPoint> points = mapservice.GetMap(service.getUser());
            return points?.Select(p => p.Description).ToList();
        }

    }
}
