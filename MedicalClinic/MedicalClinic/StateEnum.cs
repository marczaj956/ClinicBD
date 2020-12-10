using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
       enum State 
        {
            Wszystkie = 'A',
            Zarejestrowana = 'R',
            Anulowana = 'C',
            Zakonczona = 'E'
            
        }
    /*
     * Stany dla badania laboraotryjnego
     *     public static string translateRoleDB(string input)
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
     * 
     */
}
