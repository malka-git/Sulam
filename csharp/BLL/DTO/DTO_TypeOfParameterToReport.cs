using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_TypeOfParameterToReport
    {

        public int CodeDescriptionParameter { get; set; }
        public string DescriptionParameter { get; set; }


        public static DTO_TypeOfParameterToReport ToDto_TypeOfParameterToReport(Dal.TypeOfParameterToReport t)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_TypeOfParameterToReport() { CodeDescriptionParameter = t.CodeDescriptionParameter, DescriptionParameter = t.DescriptionParameter };
        }
        public static Dal.TypeOfParameterToReport ToTypeOfParameterToReport(DTO_TypeOfParameterToReport t)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.TypeOfParameterToReport() { CodeDescriptionParameter = t.CodeDescriptionParameter, DescriptionParameter = t.DescriptionParameter };
        }
        public static List<DTO_TypeOfParameterToReport> ToListDTO_TypeOfParameterToReport(List<Dal.TypeOfParameterToReport> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_TypeOfParameterToReport> lnew = new List<DTO_TypeOfParameterToReport>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToDto_TypeOfParameterToReport(e)));
            return lnew;
        }
        public static List<Dal.TypeOfParameterToReport> ToListTypeOfParameterToReports(List<DTO_TypeOfParameterToReport> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.TypeOfParameterToReport> lnew = new List<Dal.TypeOfParameterToReport>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToTypeOfParameterToReport(e)));
            return lnew;
        }
    }
}
