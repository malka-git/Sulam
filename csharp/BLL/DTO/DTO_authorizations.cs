using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public partial class DTO_authorizations
    {

        public int Code { get; set; }
        public string authorizationsDescription { get; set; }

        public static DTO_authorizations ToDto_authorizations(Dal.authorizations a)
        {
            //ממירה מופע של מחלקה מסוג מחלקה של מיקרוסופט למחלקה שלנו
            return new DTO_authorizations() { Code = a.Code, authorizationsDescription = a.authorizationsDescription };
        }
        public static Dal.authorizations ToAuthorizations(DTO_authorizations a)
        {
            //ממירה ממחלקה שלנו למחלקה של מיקרוסופט
            return new Dal.authorizations() { Code = a.Code, authorizationsDescription = a.authorizationsDescription };
        }
      public static List<DTO_authorizations> ToListDTO_authorizations(List<Dal.authorizations> la)
      {
          //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
          //הגדרנו אוסף שלנו  
          List<DTO_authorizations> lnew = new List<DTO_authorizations>();
          //רצנו על האוסף של מיקרוסופט שקיבלנו
          //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
          la.ForEach(e => lnew.Add(ToDto_authorizations(e)));
          return lnew;
      }
      public static List<Dal.authorizations> ToListauthorizations(List<DTO_authorizations> la)
      {
          //מטרת הפונקציה : הפונקציה מקבלת אוסף של מיקרוסופט ומחזירה אוסף שלנו 
          //הגדרנו אוסף שלנו  
          List<Dal.authorizations> lnew = new List<Dal.authorizations>();
          //רצנו על האוסף של מיקרוסופט שקיבלנו
          //וכל איבר בו- המרנו אותו למחלקה שלנו והוספנו אותו לאוסף
          la.ForEach(e => lnew.Add(ToAuthorizations(e)));
          return lnew;
      }
    }


}
