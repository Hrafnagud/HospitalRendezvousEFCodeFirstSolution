using HopitalRendezvousEFCodeFirstEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRendezvousEFCodeFirstBLL
{
    public static class EnumManager
    {
        public static List<Enums> BringAllSpecialties()
        {
            List<Enums> data = new List<Enums>();

            foreach (var item in Enum.GetValues(typeof(Specialties)))
            {
                Enums theEnum = new Enums()
                {
                    TheKey = Convert.ToInt32(item),
                    TheValue = item.ToString()
                };
                data.Add(theEnum);
            }
            return data;
        }
    }
}
