using HopitalRendezvousEFCodeFirstEntities;
using HospitalRendezvousEFCodeFirstDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRendezvousEFCodeFirstBLL
{
    public class DoctorManager
    {
        //Global
        MyContext myDBContext = new MyContext();

        public bool AddNewDoctor(Doctor newDoctor)
        {
            try
            {
                //First Approach
                myDBContext.Doctors.Add(newDoctor);
                //Second Approach will be used in further repository design pattern. (MVC)
                //myDBContext.Set<Doctor>().Add(newDoctor);

                myDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Doctor> BringAllActiveDoctors()
        {
            try
            {
                List<Doctor> doctorList = new List<Doctor>();
                doctorList = myDBContext.Doctors.ToList();
                return doctorList;

                //or
               //using where clause active doctors will be retrieved.
                //return myDBContext.Doctors.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
