using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public class RendezvousInfoModel
    {
        public int RendezvousId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor{ get; set; }
        public string DoctorFullName { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string PatientFullName{ get; set; }
        public DateTime RendezvousDate { get; set; }
        public string Service { get; set; }
}
}
