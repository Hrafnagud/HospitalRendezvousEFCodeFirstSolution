using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HopitalRendezvousEFCodeFirstEntities;
using HospitalRendezvousEFCodeFirstBLL;
using HospitalRendezvousEFCodeFirstDAL;

namespace HospitalRendezvousEFCodeFirstBLL
{
    public class PatientManager
    {
        //Global
        MyContext myDbContext = new MyContext();

        public List<Patient> BringAllPatients()
        {
            try
            {
                return myDbContext.Patients.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
