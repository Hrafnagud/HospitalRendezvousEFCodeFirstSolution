using HopitalRendezvousEFCodeFirstEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRendezvousEFCodeFirstDAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {

        }

        //Our Table
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<RendezvousInfo> RendezvousInfos { get; set; }
    }
}
