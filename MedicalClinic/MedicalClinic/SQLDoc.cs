using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLDoc
    {

        public class TableJoinResult
        {
            public Appointment appointmentTable { get; set; }
            public Staff staffTable { get; set; }
            public Patient patientTable { get; set; }
            public Examination_Laboratory laboratoryExaminationTable { get; set; }
            public Examination_Physical physicalExaminationTable { get; set; }
            public Exam_Dictionary examDictionaryTable { get; set; }

        }
        

        public static IQueryable<TableJoinResult> GetVisits(VisitsSearchCriteria searchCriteria)
        {
            
            DataClassesDataContext db = new DataClassesDataContext();

            IQueryable<TableJoinResult> query = (from app in db.Appointment
                                                 join pt in db.Patient
                                                 on app.Id_Patient equals pt.Id_Patient
                                                 join st in db.Staff
                                                 on app.Id_Doctor equals st.Id_Staff

                                                  select new TableJoinResult
                                                  {
                                                      appointmentTable = app,
                                                      staffTable = st,
                                                      patientTable = pt
                                                  });

            if (searchCriteria.getOnlyVisitsForDoctor())
            {
                query = query.Where(app => app.appointmentTable.Id_Doctor.Equals(searchCriteria.getDoctorId()));
            }

            if (searchCriteria.getState() != State.Wszystkie) 
            {
                query = query.Where(app => app.appointmentTable.State.Equals(searchCriteria.getStateValue()));
            }

            if (searchCriteria.getDate() != default(DateTime) && searchCriteria.getDate() != null)
            {
                query = query.Where(app => app.appointmentTable.Date_Appointment >= searchCriteria.getDate() && app.appointmentTable.Date_Appointment <= searchCriteria.getDateWithLastTimeOfTheDay());
            }

            return query;
        }


        public static IQueryable<TableJoinResult> GetPatient(PatientsSearchCriteria searchCriteria)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            IQueryable<TableJoinResult> query = (from app in db.Appointment
                                                 join pt in db.Patient
                                                 on app.Id_Patient equals pt.Id_Patient
                                                 select new TableJoinResult
                                                 {
                                                     appointmentTable = app,
                                                     patientTable = pt
                                                 });

            if (searchCriteria.getPatientId() != 0)
            {
                query = query.Where(app => app.appointmentTable.Id_Patient.Equals(searchCriteria.getPatientId()));
            }

            if (searchCriteria.getName() != null) 
            {
                query = query.Where(pt => pt.patientTable.Name.Equals(searchCriteria.getName()));
            }
            if (searchCriteria.getSurname() != null) 
            {
                query = query.Where(pt => pt.patientTable.Name.Equals(searchCriteria.getSurname()));
            }

            if (searchCriteria.getPesel() != 0 )
            {
                query = query.Where(pt => pt.patientTable.PESEL.Equals(searchCriteria.getPesel()));
            }

            return query;
        }

        public static IQueryable<TableJoinResult> GetPhysicalExamination(ExaminationsSearchCriteria searchCriteria)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            IQueryable<TableJoinResult> query = (from app in db.Appointment
                                                 join st in db.Staff
                                                 on app.Id_Doctor equals st.Id_Staff
                                                 join phy in db.Examination_Physical
                                                 on app.Id_Appointment equals phy.Id_Appointment
                                                 join dic in db.Exam_Dictionary
                                                 on phy.Exam_Code equals dic.Exam_Code
                                                 select new TableJoinResult
                                                 {
                                                     appointmentTable = app,
                                                     physicalExaminationTable = phy,
                                                     staffTable = st,
                                                     examDictionaryTable = dic
                                                 });

            if (searchCriteria.getPatientId() != 0)
            {
                query = query.Where(app => app.appointmentTable.Id_Patient.Equals(searchCriteria.getPatientId()));
            }

            if (searchCriteria.getAppointmentId() != 0)
            {
                query = query.Where(app => app.appointmentTable.Id_Appointment.Equals(searchCriteria.getAppointmentId()));
            }
           
            
            return query;
        }

        public static IQueryable<TableJoinResult> GetLaboratoryExamination(ExaminationsSearchCriteria searchCriteria)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            IQueryable<TableJoinResult> query = (from app in db.Appointment
                                                 join st in db.Staff
                                                 on app.Id_Doctor equals st.Id_Staff
                                                 join lab in db.Examination_Laboratory
                                                 on app.Id_Appointment equals lab.Id_Appointment
                                                 join dic in db.Exam_Dictionary
                                                 on lab.Exam_Code equals dic.Exam_Code
                                                 select new TableJoinResult
                                                 {
                                                     appointmentTable = app,
                                                     laboratoryExaminationTable=lab,
                                                     staffTable = st,
                                                     examDictionaryTable = dic
                                                 });

            if (searchCriteria.getPatientId() != 0)
            {
                query = query.Where(app => app.appointmentTable.Id_Patient.Equals(searchCriteria.getPatientId()));
            }

            if (searchCriteria.getAppointmentId() != 0)
            {
                query = query.Where(app => app.appointmentTable.Id_Appointment.Equals(searchCriteria.getAppointmentId()));
            }


            return query;
        }

        public static IQueryable<Appointment> GetAppointment(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Appointment
                         where
                               log.Id_Appointment==id

                         select log;
            
            return result;
        }
        public static IQueryable<Exam_Dictionary> GetLabolatoryExamination()
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Exam_Dictionary
                         where
                               log.Type == "LAB"

                         select log;

            return result;
        }
        public static IQueryable<Exam_Dictionary> GetPhysicalExamination()
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Exam_Dictionary
                         where
                               log.Type == "PHY"

            select log;

            return result;
        }

        public static IQueryable<TableJoinResult> GetAppointmentP(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from app in db.Appointment
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    where
                         app.Id_Patient == id

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        staffTable = st
                    });
        }


        public static void updateDescDia(int id, string diag, string desc, string state)
        {  
            DataClassesDataContext db = new DataClassesDataContext();
            Appointment update = db.Appointment.Single(row => row.Id_Appointment == id);
            update.Descirption = desc;
            update.State = state;
            update.Diagnosis = diag;
            db.SubmitChanges();

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


       
        public static IQueryable<TableJoinResult> GetLab(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from app in db.Appointment
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    join lab in db.Examination_Laboratory
                    on app.Id_Appointment equals lab.Id_Appointment
                    
                    where
                         app.Id_Patient == id

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        laboratoryExaminationTable = lab,
                        staffTable = st
                    });
        }



        public static IQueryable<Examination_Laboratory> GetHisL(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from lab in db.Examination_Laboratory
                         where
                               lab.Id_Examination==id

                         select lab;



            return result;
        }



        public static IQueryable<TableJoinResult> GetPhy(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from app in db.Appointment
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    join phy in db.Examination_Physical
                    on app.Id_Appointment equals phy.Id_Appointment

                    where
                         app.Id_Patient == id

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        physicalExaminationTable = phy,
                        staffTable = st
                    });
        }



        public static IQueryable<Examination_Physical> GetHisP(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from phy in db.Examination_Physical
                         where
                               phy.Id_Examination==id

                         select phy;



            return result;
        }


        public static IQueryable<TableJoinResult> GetPhyVis(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from app in db.Appointment
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    join phy in db.Examination_Physical
                    on app.Id_Appointment equals phy.Id_Appointment
                    join dic in db.Exam_Dictionary
                    on phy.Exam_Code equals dic.Exam_Code

                    where
                         app.Id_Appointment == id

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        physicalExaminationTable = phy,
                        staffTable = st,
                        examDictionaryTable = dic
                    }); ;
        }



    }
}
