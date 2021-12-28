using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public class HourViewModel
    {
        public int Id { get; set; }
        public string HourInterval { get; set; }

        public static List<HourViewModel> BringHoursList()
        {
            List<HourViewModel> list = new List<HourViewModel>()
            {
                (new HourViewModel
                {
                    Id = 9,
                    HourInterval = "09:00"
                }),
                (new HourViewModel
                {
                    Id = 10,
                    HourInterval = "10:00"
                }),
                (new HourViewModel
                {
                    Id = 11,
                    HourInterval = "11:00"
                }),
                (new HourViewModel
                {
                    Id = 13,
                    HourInterval = "13:00"
                }),
                (new HourViewModel
                {
                    Id = 14,
                    HourInterval = "14:00"
                }),
                (new HourViewModel
                {
                    Id = 15,
                    HourInterval = "15:00"
                })
            };

            return list;
        }
    }
}
