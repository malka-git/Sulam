using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_Report
    {
        public int codeCaregiver { get; set; }
        public int codeStudent { get; set; }
        public int codeParameter { get; set; }
        public string report1 { get; set; }

        //public static DTO_Report toDTO_Report(Dal.Report r)
        //{
        //    //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
        //    return new DTO_Report() { codeCaregiver = r.codeCaregiver, codeStudent =r.codeStudent, codeParameter = r.codeParameter, report1=r.report1 };
        //}
        //public static Dal.Report ToReport(DTO_Report r)
        //{
        //    //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
        //    return new Dal.Report() { codeCaregiver = r.codeCaregiver, codeStudent = r.codeStudent, codeParameter = r.codeParameter, report1 = r.report1 };
        //}
        //public static List<DTO_Report> ToListDTO_Report(List<Dal.Report> lr)
        //{
        //    //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
        //    //הגדרנו אוסף שלנו  
        //    List<DTO_Report> lnew = new List<DTO_Report>();
        //    //רצנו על האוסף של מיקרוסופט שקיבלנו
        //    //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
        //    lr.ForEach(e => lnew.Add(toDTO_Report(e)));
        //    return lnew;
        //}
        //public static List<Dal.Report> ToListReport(List<DTO_Report> lr)
        //{
        //    //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
        //    //הגדרנו אוסף שלנו  
        //    List<Dal.Report> lnew = new List<Dal.Report>();
        //    //רצנו על האוסף של מיקרוסופט שקיבלנו
        //    //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
        //    lr.ForEach(e => lnew.Add(ToReport(e)));
        //    return lnew;
        //}
    
}
}
