using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dal;
using BLL.DTO;

namespace WebApi_Sulam.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage IsExist(DTO_Login parameters)
        {
            try
            {
                var user = BLL.BllFunctions.LogInFunc.IsExist(parameters.Email, parameters.Code);
                if (user == null)
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "הנתונים שגויים");
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        //BLL.DTO.DTO_Worker w;
        //w = BLL.DTO.DTO_Worker.ToDto_worker(BLL.BllFunctions.LogInFunc.IsExist(parameters.Email, parameters.Code));
        //return Request.CreateResponse(HttpStatusCode.OK, w);
        // worker.professionType.CodeAuthorization.Value

    }
}





//namespace WebApi_Sulam.Controllers
//{
//    public class LoginController : ApiController
//{
//    [HttpPost]
//    public HttpResponseMessage IsExist(DTO_Login parameters)
//    {

//        BLL.DTO.DTO_Worker w;
//        //  var worker = LogInFunc.IsExist( mail, code);
//        //  if (worker == null)
//        // return Request.CreateErrorResponse(HttpStatusCode.Unauthorized,"הנתונים שהקשת אינם תואמים את המערכת, נסה שנית");
//        w = BLL.DTO.DTO_Worker.ToDto_worker(BLL.BllFunctions.LogInFunc.IsExist(parameters.Email, parameters.Code));

//        return Request.CreateResponse(HttpStatusCode.OK, w);


//        // worker.professionType.CodeAuthorization.Value

//    }




//}
//}
