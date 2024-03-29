﻿using HopitalRendezvousEFCodeFirstEntities;
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
                //List<Doctor> doctorList = new List<Doctor>();
                //doctorList = myDBContext.Doctors.ToList();
                //return doctorList;

                // or after adding IsActive
                //using where clause active doctors will be retrieved.
                return myDBContext.Doctors.Where(x => x.IsActive).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Doctor> BringAllDoctorsBySpecialty(Specialties specialty)
        {
            try
            {
                return myDBContext.Doctors.Where(x => x.Specialty == specialty).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Doctor FindDoctorById(int id)
        {
            try
            {
                Doctor doctor = myDBContext.Doctors.FirstOrDefault(x => x.DoctorId == id);
                return doctor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
