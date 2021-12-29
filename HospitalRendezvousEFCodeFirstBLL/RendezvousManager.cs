using HospitalRendezvousEFCodeFirstDAL;
using HopitalRendezvousEFCodeFirstEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRendezvousEFCodeFirstBLL
{
    public class RendezvousManager
    {
        //Global
        MyContext myDBContext = new MyContext();

        public List<RendezvousInfo> BringDoctorRendezvousByDate(Doctor doctor, DateTime date)
        {
            try
            {
                List<RendezvousInfo> rendezvousList = new List<RendezvousInfo>();
                rendezvousList = myDBContext.RendezvousInfos.Where(x => x.DoctorId == doctor.DoctorId).ToList();
                for (int i = 0; i < rendezvousList.Count; i++)
                {
                    if (rendezvousList[i].RendezvousDate.ToShortDateString() != date.ToShortDateString())
                    {
                        rendezvousList.Remove(rendezvousList[i]);
                    }
                }


                return rendezvousList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoesPatientHasRendezvousForChosenDate(Patient patient, DateTime date)
        {
            try
            {
                bool result = false;

                //var list = myDBContext.RendezvousInfos.Where(x => x.PatientId == patient.PatientId && x.RendezvousDate.ToShortDateString() == date.ToShortDateString()).ToList();
                var list = myDBContext.RendezvousInfos.Where(x => x.PatientId == patient.PatientId && x.RendezvousDate == date).ToList();
                result = list.Count > 0 ? true : false;

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool BookRendezvous(RendezvousInfo rendezvous)
        {
            try
            {
                myDBContext.RendezvousInfos.Add(rendezvous);
                if (myDBContext.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
