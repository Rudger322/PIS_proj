using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Repository
    {
        public List<string> Purpose;
        public List<string> Countries;
        public User user;
        public Repository()
        {
            Purpose = new List<string>() { "Работа", "Учеба", "Туризм", "Транзит", "ВНЖ" };  
            Countries = new List<string>() {"Азербайджан", "Таджикистан", "Узбекистан", "Молдова",
                "Украина", "Киргизия", "Казахстан", "Армения","Другое" }; 
        }
        public List<string> fetchPurposeList()
        {
            return Purpose;
        }
        public List<string> fetchCountryList()
        {
            return Countries;
        }
        public void Save(User userToSave)
        {
            user = userToSave;
        }

    }
    public enum Purpose
    {
        Работа,
        Учеба,
        ВНЖ,
        Транзит,
        Туризм
    }
}
