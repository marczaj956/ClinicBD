using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLDoc
    {

        public class TableJoinResult3
        {
            public Appointment Table1 { get; set; }
            public Staff Table2 { get; set; }
            public Patient Table3 { get; set; }
        }

        public static IQueryable<TableJoinResult3> GetAppointments_ID(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            return (from st in db.Staff
                    join app in db.Appointment
                    on st.Id_Staff equals app.Id_Doctor
                    where
                          app.Id_Doctor.Equals(id)

                    select new TableJoinResult3
                    {
                        Table1 = app,
                        Table2 = st
                    });
        }

        public static IQueryable<TableJoinResult3> GetVisit(string state, DateTime date)
        {
          
           DateTime date1 = date;
           TimeSpan ts = new TimeSpan(23, 59, 59);
           date = date +  ts;

            DataClassesDataContext db = new DataClassesDataContext();
            Globals.id = 6;
            return (from app in db.Appointment
                    join pt in db.Patient
                    on app.Id_Patient equals pt.Id_Patient
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    where
                   app.Id_Doctor.Equals(Globals.id) &&
                   // app.State.Equals(state) &&
                    app.Date_Appointment > date && app.Date_Appointment <= date1

                    select new TableJoinResult3
                    {
                        Table1 = app,
                        Table2 = st,
                        Table3 = pt
                    });
          
        }
        public static IQueryable<TableJoinResult3> GetAllVisit(string state, DateTime date)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            Globals.id = 1;
            return (from app in db.Appointment
                    join pt in db.Patient
                    on app.Id_Patient equals pt.Id_Patient
                    join st in db.Staff
                    on app.Id_Doctor equals st.Id_Staff
                    where
                         app.State.Equals(state) &&
                         app.Date_Appointment.Equals(date)

                    select new TableJoinResult3
                    {
                        Table1 = app,
                        Table2 = st,
                        Table3 = pt
                    });
        }
    }
}
