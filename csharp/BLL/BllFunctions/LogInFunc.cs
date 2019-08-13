using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal
    ;

namespace BLL.BllFunctions
{
  public class LogInFunc
    {
      
        public static Dal.Workers IsExist(string mail, int code)
        {
            //List<Dal.Worker>workerList;
          Workers t;
         
            using (var db = new SulamEntities())
            {
                t = db.Workers.FirstOrDefault(s => s.emailAdress == mail &&  s.Code == code);
                //Func<string, bool> IsTrue = x => x ==null;
            } 

            return t;
        }
     
        
    }
}
