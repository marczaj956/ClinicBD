using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLRec
    {
        public static IQueryable<Patient> GetPatientsList(string name, string surname, string pesel)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Patient
                         where
                               log.Surname.StartsWith(surname) &&
                               log.Name.StartsWith(name) &&
                               log.PESEL.StartsWith(pesel)

                         select log;



            return result;
        }
        public static void insertPatient(string name, string surname, string pesel)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();

            Patient addPatient = new Patient();
            addPatient.Name = name;
            addPatient.Surname = surname;
            addPatient.PESEL = pesel;


            db.Patient.InsertOnSubmit(addPatient);
            db.SubmitChanges();
        }
        public static void ExecuteAppointment(DateTime date, int iddoc, int idrec, string desc, string diagno, int idpat,string state)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();

            Appointment addappointment = new Appointment();
            addappointment.Date_Appointment = date;
            addappointment.Id_Doctor = iddoc;
            addappointment.Id_Receptionist = idrec;
            addappointment.Descirption = desc;
            addappointment.Diagnosis = diagno;
            addappointment.Id_Patient = idpat;
            addappointment.State = state;
            db.Appointment.InsertOnSubmit(addappointment);
            db.SubmitChanges();
        }

        public static IQueryable<Appointment> GetApo(int idpat)
        { 
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from apo in db.Appointment
                         where
                               apo.Id_Patient.Equals(idpat)

                         select apo;



            return result;
        }

        public static IQueryable<Appointment> GetApo(int idpat, string state, int iddoc, string date)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from apo in db.Appointment
                         where
                               apo.Id_Patient.Equals(idpat) &&
                               apo.State.StartsWith(state) &&
                               apo.Id_Doctor.Equals(iddoc) &&
                               apo.Date_Appointment.Equals(date)

                         select apo;



            return result;
        }
        public static IQueryable<Appointment> GetApo(int idpat, string state, int iddoc)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from apo in db.Appointment
                         where
                               apo.Id_Patient.Equals(idpat) &&
                               apo.State.StartsWith(state) &&
                               apo.Id_Doctor.Equals(iddoc) 
                               

                         select apo;



            return result;
        }

        public static IQueryable<Appointment> GetApo(int idpat, string state)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from apo in db.Appointment
                         where
                               apo.Id_Patient.Equals(idpat) &&
                               apo.State.StartsWith(state) 


                         select apo;



            return result;
        }



    }
}
