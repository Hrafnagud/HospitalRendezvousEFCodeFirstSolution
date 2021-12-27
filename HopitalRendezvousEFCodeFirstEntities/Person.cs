using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalRendezvousEFCodeFirstEntities
{
    public abstract class Person
    {
        [Required]
        [StringLength(11)]
        public string TRID { get; set; }

        [StringLength(11)]  //05xxxxxxxxx
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
    }
}
