using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public class Doctor : Person, IPaid
    {
        //Data Annotations  (after entity framework package installed)
        [Key]
        [Column(Order = 1)]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Please enter a doctor name!")]
        [StringLength(50)]
        [Display(Name = "Doctor Name")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage = "Please enter a doctor surname!")]
        [StringLength(50)]
        [Display(Name = "Doctor Surname")]
        public string DoctorSurname { get; set; }

        [Display(Name = "Doctor Specialty")]
        public Specialties Specialty{ get; set; }

        [Display(Name = "Salary")]
        public decimal Salary { get; set; }
    }
}
