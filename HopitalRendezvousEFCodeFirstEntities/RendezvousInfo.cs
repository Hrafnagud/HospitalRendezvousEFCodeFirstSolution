using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public class RendezvousInfo
    {
        [Key]
        [Column(Order = 1)]
        public int Id{ get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime RendezvousDate { get; set; }
    }
}
