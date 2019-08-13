using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dal;

namespace WebApi_Sulam.Controllers
{
    public class CaregiverController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getAllTreatmentsByCaregiverId(int id)
        {
            List<Treatment> list = BLL.BllFunctions.TreatmentFunc.GetTreatmentByCaregiverId(id);
            return Ok(list);
        }
    }
}
