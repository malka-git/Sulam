using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_PersonalFile
    {
        public int codeStudent { get; set; }
        public string medicalBackground { get; set; }
        public static DTO_PersonalFile toDTO_PersonalFile(Dal.PersonalFile p)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_PersonalFile() { codeStudent = p.codeStudent, medicalBackground = p.medicalBackground};
        }
        public static Dal.PersonalFile ToPersonalFile(DTO_PersonalFile p)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.PersonalFile() { codeStudent = p.codeStudent, medicalBackground = p.medicalBackground};
        }
        public static List<DTO_PersonalFile> ToListDTO_PersonalFile(List<Dal.PersonalFile> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_PersonalFile> lnew = new List<DTO_PersonalFile>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(toDTO_PersonalFile(e)));
            return lnew;
        }
        public static List<Dal.PersonalFile> ToListPersonalFile(List<DTO_PersonalFile> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.PersonalFile> lnew = new List<Dal.PersonalFile>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToPersonalFile(e)));
            return lnew;
        }
    
}
}
