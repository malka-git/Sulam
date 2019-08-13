using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_ParameterReport
    {
        public int code { get; set; }
        public int codeProfessionType { get; set; }
        public int codeParameter { get; set; }


        public static DTO_ParameterReport toDTO_ParameterReport(Dal.ParameterReport p)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_ParameterReport() { code = p.code, codeProfessionType =p.codeProfessionType, codeParameter =p.codeParameter};
        }
        public static Dal.ParameterReport ToParameterReport(DTO_ParameterReport p)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.ParameterReport() { code = p.code, codeProfessionType = p.codeProfessionType, codeParameter = p.codeParameter };
        }
        public static List<DTO_ParameterReport> ToListDTO_ParameterReport(List<Dal.ParameterReport> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_ParameterReport> lnew = new List<DTO_ParameterReport>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(toDTO_ParameterReport(e)));
            return lnew;
        }
        public static List<Dal.ParameterReport> ToListParameterReport(List<DTO_ParameterReport> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.ParameterReport> lnew = new List<Dal.ParameterReport>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToParameterReport(e)));
            return lnew;
        }
    }
}

