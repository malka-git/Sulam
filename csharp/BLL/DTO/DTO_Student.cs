using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_Student
    {
        public int code { get; set; }
        public string studentName { get; set; }
        public string lastName { get; set; }
        public Nullable<int> codeClass { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string phone { get; set; }
        public string celPhone1 { get; set; }
        public string celPhone2 { get; set; }
        public string id { get; set; }
        public Nullable<int> codeCity { get; set; }

        public static DTO_Student ToDto_student(Dal.Student a)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_Student() { code = a.code, studentName = a.studentName,lastName=a.lastName,codeClass=a.codeClass,birthDate=a.birthDate,fatherName=a.fatherName,motherName=a.motherName,phone=a.phone,celPhone1=a.celPhone1,celPhone2=a.celPhone2,id=a.id,codeCity=a.codeCity };
        }
        public static Dal.Student ToStudents(DTO_Student a)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.Student() { code = a.code, studentName = a.studentName, lastName = a.lastName, codeClass = a.codeClass, birthDate = a.birthDate, fatherName = a.fatherName, motherName = a.motherName, phone = a.phone, celPhone1 = a.celPhone1, celPhone2 = a.celPhone2, id = a.id, codeCity = a.codeCity };
        }
        public static List<DTO_Student> ToListDTO_student(List<Dal.Student> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_Student> lnew = new List<DTO_Student>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToDto_student(e)));
            return lnew;
        }
        public static List<Dal.Student> ToListstudent(List<DTO_Student> la)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.Student> lnew = new List<Dal.Student>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            la.ForEach(e => lnew.Add(ToStudents(e)));
            return lnew;
        }
    }
}
