
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_Treatment
    {
        public int Code { get; set; }
        public Nullable<int> codeCaregiver { get; set; }
        public Nullable<int> codeStudent { get; set; }
        public string treatmentDescription { get; set; }
        public Nullable<int> grade { get; set; }
        public Nullable<System.DateTime> treatmentDate { get; set; }

        public static DTO_Treatment ToDTO_Treatment(Dal.Treatment a)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_Treatment() { Code = a.Code, codeCaregiver= a.codeCaregiver,codeStudent=a.codeStudent,treatmentDescription=a.treatmentDescription,grade=a.grade,treatmentDate=a.treatmentDate };
        }
        public static Dal.Treatment ToTreatment(DTO_Treatment a)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.Treatment() { Code = a.Code, codeCaregiver = a.codeCaregiver, codeStudent = a.codeStudent, treatmentDescription = a.treatmentDescription, grade = a.grade, treatmentDate = a.treatmentDate };
        }
        public static List<DTO_Treatment> ToListDTO_treatment(List<Dal.Treatment> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_Treatment> lnew = new List<DTO_Treatment>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToDTO_Treatment(e)));
            return lnew;
        }
        public static List<Dal.Treatment> ToListauthorizations(List<DTO_Treatment> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.Treatment> lnew = new List<Dal.Treatment>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToTreatment(e)));
            return lnew;
        }
    }
}
