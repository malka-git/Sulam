using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DTO_City
    {

        public int Code { get; set; }
        public string CityName { get; set; }

        public static DTO_City ToDto_City(Dal.City c)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_City() { Code = c.Code, CityName = c.CityName };
        }
        public static Dal.City ToCity(DTO_City c)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.City() { Code = c.Code, CityName = c.CityName };
        }
        public static List<DTO_City> ToListDTO_City(List<Dal.City> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<DTO_City> lnew = new List<DTO_City>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToDto_City(e)));
            return lnew;
        }
        public static List<Dal.City> ToListCity(List<DTO_City> lc)
        {
            //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
            //הגדרנו אוסף שלנו  
            List<Dal.City> lnew = new List<Dal.City>();
            //רצנו על האוסף של מיקרוסופט שקיבלנו
            //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
            lc.ForEach(e => lnew.Add(ToCity(e)));
            return lnew;
        }
    }
}
