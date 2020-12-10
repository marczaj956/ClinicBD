using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLLab
    {
        public static string translateRoleDB(string input)
        {
            string translate = "";
            if (input == "Anulowane") translate = "ANU";
            else if (input == "Zlecone") translate = "ZLE";
            else if (input == "Wykonane") translate = "WYK";
            else if (input == "Zatwierdzone") translate = "ZAT";
            else if (input == "Zakonczone") translate = "ZAK";
            else if (input == "Wszystkie") translate = "";
            return translate;
        }

        public static string translateRolePL(string input)
        {
            string translate = "";
            if (input == "ANU") translate = "Anulowane";
            else if (input == "ZLE") translate = "Zlecone";
            else if (input == "WYK") translate = "Wykonane";
            else if (input == "ZAT") translate = "Zatwierdzone";
            else if (input == "ZAK") translate = "Zakonczone";
            return translate;
        }
        public class TableJoinResult2
        {
            public Examination_Laboratory Table1 { get; set; }
            public Exam_Dictionary Table2 { get; set; }
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
                    });
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

        public static IQueryable<Patient> GetPatientData(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Patient
                         where
                               log.Id_Patient == id

                         select log;



            return result;
        }
        public static void updateLabExam(int id, string state, string result, string comment_lab)
        {   //napisać ifa czy są dane
            DataClassesDataContext db = new DataClassesDataContext();
            Examination_Laboratory update = db.Examination_Laboratory.Single(row => row.Id_Examination == id);
            update.Result = result;
            update.State = state;
            update.Comments_Man_Lab = comment_lab;

            db.SubmitChanges();

        }
        public static IQueryable<TableJoinResult2> GetExamination_Laboratories(string type, string state, string date)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from dic in db.Exam_Dictionary
                    join lab in db.Examination_Laboratory
                    on dic.Exam_Code equals lab.Exam_Code
                    where
                          lab.State.StartsWith(state) &&
                          dic.Type.StartsWith(type) &&
                          lab.Date_Of_Order.Equals(date)

                    select new TableJoinResult2
                    {
                        Table1 = lab,
                        Table2 = dic
                    });
        }
        public static IQueryable<TableJoinResult2> GetExamination_Laboratories2(string type, string state)
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


    }
}
