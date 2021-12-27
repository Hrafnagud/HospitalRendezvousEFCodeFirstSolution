using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public class Enums
    {
        public int TheKey{ get; set; }
        public string TheValue{ get; set; }
    }
    
    public enum Specialties : Byte
    {
        NoSpecialty,
        Internal,
        Otorhinolaryngology,    //a medical specialty concerned especially with the ear, nose, and throat and related parts of the head and neck (Turkish correspondence: KBB)
        Ophthalmology,
        Orthopedics,
        Cardiology
    }
}
