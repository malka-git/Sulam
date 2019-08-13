using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.BllFunctions
{
  public  class TreatmentFunc
    {
        //שליפה מהמסד את כל הטיפולים לפי קוד מטפל
        public static List<Dal.Treatment> GetTreatmentByCaregiverId(int id)
        {
            List<Dal.Treatment> treatmentList;/*= new List<DTO.DTO_Treatment>();*/
            //לפתוח את המסד וסוגר בסיום הפונקציה
            using (var db = new SulamEntities())
                {
                     treatmentList = db.Treatment.Where(s => s.codeCaregiver == id).ToList();
                }
            return treatmentList;
        }


        
    }
    
}
