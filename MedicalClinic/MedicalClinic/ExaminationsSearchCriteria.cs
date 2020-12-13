using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class ExaminationsSearchCriteria
    {
        private int appointmentId;
        private int patientId;

        public int getAppointmentId()
        {
            return appointmentId;
        }

        public void setAppointmentId(int appointmentId)
        {
            this.appointmentId = appointmentId;
        }
        public int getPatientId()
        {
            return patientId;
        }

        public void setPatientId(int patientId)
        {
            this.patientId = patientId;
        }
       


    }
}
