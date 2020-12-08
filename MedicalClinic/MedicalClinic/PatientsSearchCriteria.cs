using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class PatientsSearchCriteria
    {
        private int patientId;
        private string name;
        private string surname;
        private long pesel;


        public void setPatientId(int patientId)
        {
            this.patientId = patientId;
        }

        public int getPatientId()
        {
            return patientId;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        { 
            return name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return surname;
        }
        public void setPesel(long pesel)
        {
            this.pesel = pesel;
        }

        public long getPesel()
        {
            return pesel;
        }

    }
}
