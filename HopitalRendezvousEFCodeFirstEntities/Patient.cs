using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    [Table("Patients")] //Table names which will be generated, are stated here.
    public class Patient : Person
    {
        [Key]
        [Column(Order = 1)]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Please enter a patient name!")]
        [StringLength(50)]
        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Please enter a patient surname!")]
        [StringLength(50)]
        [Display(Name = "Patient Surname")]
        public string PatientSurname { get; set; }

        public virtual List<RendezvousInfo> RendezvousInfoList { get; set; }

        public override string ToString()
        {
            return $"{this.TRID} {this.PatientName} {this.PatientSurname}";
        }
    }
}
