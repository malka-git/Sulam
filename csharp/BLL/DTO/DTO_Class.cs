using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_Class
    {
        public int Code { get; set; }
        public string className { get; set; }
        public Nullable<int> codeTeacher { get; set; }
        public Nullable<System.DateTime> Theyear { get; set; }
        public Nullable<int> CodesubstituteTeacher { get; set; }
        public Nullable<bool> IsSubsitute { get; set; }


        public static DTO_Class toDTO_Class(Dal.Class c)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_Class() { Code = c.Code, className = c.className, codeTeacher = c.codeTeacher, Theyear = c.Theyear, CodesubstituteTeacher = c.CodesubstituteTeacher, IsSubsitute = c.IsSubsitute };
        }
        public static Dal.Class ToClass(DTO_Class c)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.Class() { Code = c.Code, className = c.className, codeTeacher = c.codeTeacher, Theyear =c.Theyear , CodesubstituteTeacher =c.CodesubstituteTeacher , IsSubsitute =c.IsSubsitute };
        }
        public static List<DTO_Class> ToListDTO_Class(List<Dal.Class> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_Class> lnew = new List<DTO_Class>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(toDTO_Class(e)));
            return lnew;
        }
        public static List<Dal.Class> ToListClass(List<DTO_Class> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.Class> lnew = new List<Dal.Class>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToClass(e)));
            return lnew;
        }
    }
}