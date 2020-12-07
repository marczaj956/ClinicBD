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
        }

        public static IQueryable<TableJoinResult> GetAppointments_ID(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from st in db.Staff
                    join app in db.Appointment
                    on st.Id_Staff equals app.Id_Doctor
                    where
                          app.Id_Doctor.Equals(id)

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        staffTable = st
                    });
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

            if (searchCriteria.getState() != State.Wszystkie) //&& searchCriteria.getState() != "")
            {
                query = query.Where(app => app.appointmentTable.State.Equals(searchCriteria.getState()));
            }

            if (searchCriteria.getDate() != null)
            {
                query = query.Where(app => app.appointmentTable.Date_Appointment >= searchCriteria.getDate() && app.appointmentTable.Date_Appointment <= searchCriteria.getDateWithLastTimeOfTheDay());
            }

            return query;
        }

        public static IQueryable<TableJoinResult> GetPatient(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from app in db.Appointment
                    join pt in db.Patient
                    on app.Id_Patient equals pt.Id_Patient
                    where
                         app.Id_Patient == id

                    select new TableJoinResult
                    {
                        appointmentTable = app,
                        patientTable = pt
                    });
        }

        public static IQueryable<Patient> GetPatientsList(string pesel)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var result = from log in db.Patient
                         where
                               log.PESEL.StartsWith(pesel)

                         select log;
            
            return result;
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
    }
}
