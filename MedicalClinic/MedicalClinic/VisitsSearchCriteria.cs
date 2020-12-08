using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class VisitsSearchCriteria
    {
        private  State state;
        private DateTime date;
        private DateTime dateWithLastTimeOfTheDay;
        private bool onlyVisitsForDoctor;
        private int doctorId;

        public State getState()
        {
            return state;
        }
        public char getStateValue()
        {
            char z = (char) state;
            return z;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public int getDoctorId()
        {
            return doctorId;
        }

        public void setDoctorId(int doctorId)
        {
            this.doctorId = doctorId;
        }

        public bool getOnlyVisitsForDoctor()
        {
            return onlyVisitsForDoctor;
        }

        public void setOnlyVisitsForDoctor(bool onlyVisitsForDoctor)
        {
            this.onlyVisitsForDoctor = onlyVisitsForDoctor;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
            this.dateWithLastTimeOfTheDay = date + new TimeSpan(23, 59, 59);
        }

        public DateTime getDateWithLastTimeOfTheDay()
        {
            return dateWithLastTimeOfTheDay;
        }
    }
}
