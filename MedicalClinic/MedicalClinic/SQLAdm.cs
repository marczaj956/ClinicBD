using MedicalClinic.Controls.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLAdm
    {

        


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

       
        
       
       

       
      
        
       
       

        
       
    }
}
