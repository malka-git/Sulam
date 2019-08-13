using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BllFunctions;
using BLL.DTO;
using Dal;

namespace WebApi_Sulam.Controllers
{
    public class SecretaryController : ApiController
    {
        [Route("addWorker")]
        [HttpPost]
        public IHttpActionResult AddWorker([FromBody] Workers worker)//מחזיר תוצאה האם ההוספה בוצעה או לא
        {
            try
            {
                secretaryFunc.AddWorker(worker);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [Route("deleteWorker")]
        [HttpDelete]//מחיקה של מורה מסוים
        public IHttpActionResult DeleteWorker(int code)
        {
            try
            {
                secretaryFunc.DeleteWorker(code);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [Route("putWorker")]
        [HttpPut]
        public IHttpActionResult UpdateWorker(Workers worker)
        {
            try
            {
                secretaryFunc.UpdateWorker(worker);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [Route("getWorker")]
        [HttpGet]
        public HttpResponseMessage GetWorker(int id)//מחזיר תוצאה הכוללת בתוכה אובייקטים
        {
            return Request.CreateResponse(HttpStatusCode.OK, secretaryFunc.GetWorker(id));
        }
        //[HttpGet]
        //public HttpResponseMessage Login(string userName, string password)//מחזיר תוצאה הכוללת בתוכה אובייקטים
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, secretaryFunc.(userName, password));
        //}
        [Route("addStudent")]
        [HttpPost]
        public IHttpActionResult addStudent(Student student)//מחזיר תוצאה האם ההוספה בוצעה או לא
        {
            try
            {
                secretaryFunc.AddStudent(student);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [Route("deleteStudent")]
        [HttpDelete]//מחיקה של תלמיד מסוים
        public IHttpActionResult DeleteStudent(int code)
        {
            try
            {
                secretaryFunc.DeleteStudent(code);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [Route("getStudent")]
        [HttpGet]//שליפה של תלמיד מסוים
        public HttpResponseMessage GetStudent(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, secretaryFunc.GetStudent(id));
        }
        [Route("putStudent")]
        [HttpPut]
        public IHttpActionResult UpdateStudent(Student student)
        {
            try
            {
                secretaryFunc.UpdateStudent(student);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}