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
        private int examinationId;
        private string examinationName = "";

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
        public int getExaminationId()
        {
            return examinationId;
        }

        public void setExaminationId(int examinationId)
        {
            this.examinationId = examinationId;
        }

        public string getExaminationName()
        {
            return examinationName;
        }

        public void setExaminationName(string examinationName)
        {
            this.examinationName = examinationName;
        }

    }
}
