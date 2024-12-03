using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Service
    {
        private Repository rep;
        public List<string> getRelevantPurose()
        {
            return rep.fetchPurposeList();
        }
        public List<string> getCountries()
        {
            return rep.fetchCountryList();
        }
        public void addInfo(User user)
        {
            rep.Save(user);
        }
        public User getUser()
        {
            if (rep.user == null)
            {
                throw new InvalidOperationException("Пользователь не зарегистрирован.");
            }
            return rep.user;
        }
        public Service(Repository repository)
        {
            rep = repository;
        }

    }
}
