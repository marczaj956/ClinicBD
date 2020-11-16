using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class GlobalVar
    {
        //Przykłąd jak zrobić globala
        private static string v_VarOne = "";
        public static string VarOne
        {
            get { return v_VarOne; }
            set { v_VarOne = value; }
        }


    }
}
