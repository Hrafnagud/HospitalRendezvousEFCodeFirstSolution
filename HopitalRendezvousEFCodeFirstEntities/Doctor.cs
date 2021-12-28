using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    [Table("Doctors")]
    public class Doctor : Person, IPaid
    {
        //Data Annotations  (after entity framework package installed)
        [Key]
        [Column(Order = 1)]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Please enter a doctor name!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Doctor name must contain at least 2, and utmost 50 character!")]
        [Display(Name = "Doctor Name")]
        public string DoctorName { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Please enter a doctor surname!")]
        [StringLength(50)]
        [Display(Name = "Doctor Surname")]
        public string DoctorSurname { get; set; }

        [Display(Name = "Doctor Specialty")]
        public Specialties Specialty{ get; set; }

        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        public virtual List<RendezvousInfo> RendezvousInfoList { get; set; }

        public override string ToString()
        {
            return $"Dr. {DoctorName} {DoctorSurname}";
        }
    }
}
