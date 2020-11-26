using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class SQLMain
    {
        public static IQueryable<Staff> CheckLog(string login, string password)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            var result = from log in db.Staff
                         where log.Login == login &&
                               log.Password == password &&
                               log.Active == 'T'
                         select log;

            return result;
        }
    }
}
