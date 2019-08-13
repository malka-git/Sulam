using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_Worker
    {
        public int Code { get; set; }
        public string id { get; set; }
        public string workerName { get; set; }
        public string workerLastName { get; set; }
        public Nullable<int> codeProfession { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public Nullable<int> cityCode { get; set; }
        public string emailAdress { get; set; }

        public static DTO_Worker ToDto_worker(Dal.Workers w)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_Worker() { Code = w.Code, id = w.id,workerName=w.workerName,workerLastName=w.workerLastName,codeProfession=w.codeProfession,birthdate=w.birthdate,cityCode=w.cityCode,emailAdress=w.emailAdress };
        }
        public static Dal.Workers ToWorker(DTO_Worker w)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.Workers() { Code = w.Code, id = w.id, workerName = w.workerName, workerLastName = w.workerLastName, codeProfession = w.codeProfession, birthdate = w.birthdate, cityCode = w.cityCode, emailAdress = w.emailAdress };
        }
        public static List<DTO_Worker> ToListDTO_Workers(List<Dal.Workers> lw)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_Worker> lnew = new List<DTO_Worker>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lw.ForEach(e => lnew.Add(ToDto_worker(e)));
            return lnew;
        }
        public static List<Dal.Workers> ToListWork(List<DTO_Worker> lw)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.Workers> lnew = new List<Dal.Workers>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lw.ForEach(e => lnew.Add(ToWorker(e)));
            return lnew;
        }

    }
}
