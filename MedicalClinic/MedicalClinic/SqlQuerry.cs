using MedicalClinic.Controls.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SqlQuerry
    {

        public static IQueryable<Staff> CheckLog(string login, string password)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            var result = from log in db.Staff
                         where log.Login == login &&
                               log.Password == password &&
                               log.Active == 'T'
                         select log;

            return result;
        }


        public static IQueryable<Staff> GetStaff(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Staff
                         where
                                log.Id_Staff== id                         
                         select log;



            return result;
        }


        public static IQueryable<Staff> GetStaff(string name, string surname, string login, string role)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Staff
                         where
                               log.Login.StartsWith(login) &&
                               log.Surname.StartsWith(surname) &&
                               log.Name.StartsWith(name) &&
                               log.Role.StartsWith(role)

                         select log;



            return result;
        }





        public static void insertstaff(string name, string surname, string login, string password, string role, char active)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();

            Staff addstaff = new Staff();
            addstaff.Name = name;
            addstaff.Surname = surname;
            addstaff.Login = login;
            addstaff.Password = password;
            addstaff.Role = role;
            addstaff.Active = active;
            db.Staff.InsertOnSubmit(addstaff);
            db.SubmitChanges();
        }

        public static void updatestaff(string name, string surname, string password, string role, char active,int id)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();
            Staff update = db.Staff.Single(row => row.Id_Staff == id);
            update.Name = name;
            update.Surname = surname;
            update.Password = password;
            update.Role = role;
            update.Active = active;
            db.SubmitChanges();
            
        }
       





        public static string translateRoleDB(string input)
        {
            string translate = "";
            if (input == "Administrator") translate = "Admin";
            else if (input == "Lekarz") translate = "Doc";
            else if (input == "Rejestrator") translate = "Rec";
            else if (input == "Kierownik labolatorium") translate = "MLab";
            else if (input == "Laborant") translate = "Lab";
            return translate;
        }

        public static string translateRolePL(string input)
        {
            string translate = "";
            if (input == "Admin") translate = "Administrator";
            else if (input == "Doc") translate = "Lekarz";
            else if (input == "Rec") translate = "Rejestrator";
            else if (input == "MLab") translate = "Kierownik labolatorium";
            else if (input == "Lab") translate = "Laborant";
            return translate;
        }


        public static IQueryable<Patient> GetPatient(string name, string surname, string Pesel)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from pat in db.Patient
                         where
                               pat.Name.StartsWith(name) &&
                               pat.Surname.StartsWith(surname) &&
                               pat.PESEL.StartsWith(Pesel)
                         select pat;



            return result;
        }

        public class TableJoinResult
        {
            public Appointment Table1 { get; set; }
            public Patient Table2 { get; set; }
        }

        public static IQueryable<TableJoinResult> pacjent(string name, string surname, string Pesel)

        {

            DataClassesDataContext db = new DataClassesDataContext();
            return (from apo in db.Appointment
                    join pat in db.Patient
                    on apo.Id_Patient equals pat.Id_Patient
                    where

                          pat.Surname.StartsWith("") &&
                          apo.State.StartsWith("")
                    select new TableJoinResult
                    {
                        Table1 = apo,
                        Table2 = pat
                    });

        }

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
        
        public static IQueryable<Patient> GetPatientData(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Patient
                         where
                               log.Id_Patient == id

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

        public static void ExecuteAppointment(DateTime date, int iddoc, int idrec, string desc, string diagno, int idpat)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();

            Appointment addappointment = new Appointment();
            addappointment.Date_Appointment = date;
            addappointment.Id_Doctor = iddoc;
            addappointment.Id_Receptionist = idrec;
            addappointment.Descirption = desc;
            addappointment.Diagnosis = diagno;
            addappointment.Id_Patient = idpat;
            db.Appointment.InsertOnSubmit(addappointment);
            db.SubmitChanges();
        }
        public class TableJoinResult2
        {
            public Examination_Laboratory Table1 { get; set; }
            public Exam_Dictionary Table2 { get; set; }
        }
        public static IQueryable<TableJoinResult2> GetExamination_Laboratories(string type, string state, string date)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from dic in db.Exam_Dictionary
                    join lab in db.Examination_Laboratory
                    on dic.Exam_Code equals lab.Exam_Code
                    where
                          lab.State.StartsWith(state) &&
                          dic.Type.StartsWith(type)
                         
                    select new TableJoinResult2
                    {
                        Table1 = lab,
                        Table2 = dic
                    });
        }
        public static IQueryable<TableJoinResult2> GetExamination_Laboratories_ID(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from dic in db.Exam_Dictionary
                    join lab in db.Examination_Laboratory
                    on dic.Exam_Code equals lab.Exam_Code
                    where
                          lab.Id_Examination.Equals(id)

                    select new TableJoinResult2
                    {
                        Table1 = lab,
                        Table2 = dic
                    }) ; 
        }
       

        public static IQueryable<Appointment> GetPacjentID(int id)

        {

            
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Appointment
                         where
                               log.Id_Appointment == id

                         select log;
            return result;
        }
        public static void updateLabExam(int id,string state,string result,string comment_lab)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();
            Examination_Laboratory update = db.Examination_Laboratory.Single(row => row.Id_Examination == id);
            update.Result = result;
            update.State = state;
            update.Comments_Man_Lab = comment_lab;
           
            db.SubmitChanges();

        }
    }
}
