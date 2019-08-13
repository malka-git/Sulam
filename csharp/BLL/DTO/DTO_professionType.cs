using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_professionType
    {
        public int Code { get; set; }
        public string nameProfession { get; set; }
        public Nullable<int> CodeAuthorization { get; set; }

        public static DTO_professionType toDTO_professionType(Dal.professionType p)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_professionType() { Code = p.Code, nameProfession = p.nameProfession, CodeAuthorization =p.CodeAuthorization };
        }
        public static Dal.professionType ToprofessionType(DTO_professionType p)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.professionType() { Code = p.Code, nameProfession = p.nameProfession, CodeAuthorization = p.CodeAuthorization };
        }
        public static List<DTO_professionType> ToListDTO_professionType(List<Dal.professionType> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_professionType> lnew = new List<DTO_professionType>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(toDTO_professionType(e)));
            return lnew;
        }
        public static List<Dal.professionType> ToListprofessionType(List<DTO_professionType> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.professionType> lnew = new List<Dal.professionType>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToprofessionType(e)));
            return lnew;
        }
    }
}
