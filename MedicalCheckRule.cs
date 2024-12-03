using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MedicalCheckRule : IRule
    {
        public List<MapPoint> Apply(User user)
        {
            DateTime entryDate = user.DateOfEntry;
            DateTime medicalCheckDeadline;

            if (user.Purpose == Purpose.Работа)
            {
                medicalCheckDeadline = entryDate.AddDays(30);
            }
            else if (user.Purpose != Purpose.Работа && DateTime.Today.AddDays(90) > entryDate && user.IsLongStay)
            {
                medicalCheckDeadline = entryDate.AddDays(90);
            }
            else
            {
                medicalCheckDeadline = DateTime.MaxValue;
            }

            if (DateTime.Today > medicalCheckDeadline)
            {
                return new List<MapPoint>
            {
                new MapPoint("Ваша дорожная карта:\n- Вы просрочили срок прохождения медицинского освидетельствования! Обратитесь в миграционную службу.")
            };
            }

            if (medicalCheckDeadline != DateTime.MaxValue)
            {
                return new List<MapPoint>
            {
                new MapPoint($"- Вы должны предоставить результат медицинского освидетельствования до {medicalCheckDeadline:dd.MM.yyyy}. Справку вы можете оформить в медицинской организации.\n")
            };
            }

            return new List<MapPoint>();
        }
    }
}
