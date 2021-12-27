using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    [Table("RendezvousInformation")]
    public class RendezvousInfo
    {
        [Key]
        [Column(Order = 1)]
        public int RendezvousId{ get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime RendezvousDate { get; set; }

        //relation
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
    }
}
