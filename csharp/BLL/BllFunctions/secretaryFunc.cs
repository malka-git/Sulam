using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace BLL.BllFunctions
{
    public class secretaryFunc
    {
        //הוספה מחיקה עדכון ושליפה אנשי צוות
        public static void AddWorker( Workers worker)
        {
            using (var db = new SulamEntities())
            {
               
                db.Workers.Add(worker);
                db.SaveChanges();
            }
        }
        public static void DeleteWorker(int WorkerCode)
        {
            using (var db = new SulamEntities())
            {
                Workers worker = db.Workers.Where(u => u.Code == WorkerCode).First();
                db.Workers.Remove(worker);
                db.SaveChanges();
            }
        }
        public static void UpdateWorker(Workers newWorker)
        {
            using (var db = new SulamEntities())
            {
                Workers worker = db.Workers.Where(u => u.Code == newWorker.Code).First();
                db.Workers.Remove(worker);
                db.Workers.Add(newWorker);
                db.SaveChanges();
            }
        }
        public static Workers GetWorker(int id)
        {
            using (var db = new SulamEntities())
            {
                return db.Workers.Where(u => u.Code == id).First();
            }
        }
        //הוספה מחיקה עדכון ושליפה ילדי המוסד
        public static void AddStudent(Student student)
        {
            using (var db = new SulamEntities())
            {
                db.Student.Add(student);
                db.SaveChanges();
            }
        }
        public static void DeleteStudent(int studentCode)
        {
            using (var db = new SulamEntities())
            {
                Student student = db.Student.Where(s => s.code == studentCode).First();
                db.Student.Remove(student);
                db.SaveChanges();
            }
        }
        public static void UpdateStudent(Student newStudent)
        {
            using (var db = new SulamEntities())
            {
               Student student = db.Student.Where(u => u.code == newStudent.code).First();
                db.Student.Remove(student);
                db.Student.Add(newStudent);
                db.SaveChanges();
            }
        }
        public static Student GetStudent(int id)
        {
            using (var db = new SulamEntities())
            {
                return db.Student.Where(u => u.code == id).First();
            }
        }
        //פונקציה לשליחת מייל לאנשי צוות המוזמנים יום קודם האסיפה
        public static void SendEmail4meeting(DateTime dateTime)
        {
            DateTime tomorrow = DateTime.Now.AddDays(1);
            List<Dal.Workers> workers4Meeting;
            using (var db = new SulamEntities())
            {
                var meetingCode = db.Meetings.Where(s => s.date.ToString() == tomorrow.ToShortDateString()).First().codeMeeting;
                workers4Meeting = db.Workers.Where(u => u.Code == meetingCode).ToList();
            }
            foreach (var item in workers4Meeting)
            {
                MailMessage mail = new MailMessage("thisistzip@gmail.com", item.emailAdress, "test", "test");
                SmtpClient client = new SmtpClient();
                client.Port = 258;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                //client.EnableSsl = true;
                //client.Timeout = 10000;
                //client.Credentials = new System.Net.NetworkCredential("user@gmail.com", "password");
                mail.Subject = "this is a test email.";
                mail.Body = "this is my test email body";
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mail);
            }
        }
       
        
        //פונקציה לרשימת תלמידים לפי קוד כתה
        public static void getStudentsByClass(int code)
        {
            List<Dal.Student> classList;
            using (var db = new SulamEntities())
            {
                classList = db.Student.Where(s => s.codeClass == code).ToList();
            }
        }
        //פונקציה לרשימת מורות לפי קוד כתה
        public static void getTeacherByClass(int code)
        {
        }

        //
    }
}
