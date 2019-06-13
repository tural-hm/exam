using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam.DAL;
using Exam.Models;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExamContext db = new ExamContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddDers(Ders Ders)
        {

            Ders yeni = new Ders();
            yeni.Kod = Ders.Kod;
            yeni.Name = Ders.Name;
            yeni.Number = Ders.Number;
            yeni.TeacherName = Ders.TeacherName;
            yeni.TeacherSurname = Ders.TeacherSurname;
            db.Dersler.Add(yeni);
            db.SaveChanges();
            return View("Index");
        }
        [HttpPost]
        public ActionResult AddSagird(Sagird Sagird)
        {

            Sagird yeni = new Sagird();
            yeni = Sagird;
            db.Sagirdler.Add(yeni);
            db.SaveChanges();
            return View("Index");
        }

        [HttpPost]
        public ActionResult AddImtahan(Imtahan Imtahan)
        {

            Imtahan yeni = new Imtahan();
            yeni = Imtahan;
            //yeni.Sagird = db.Sagirdler.FirstOrDefault(x=>x.Nomre==Imtahan.)
            db.Imtahanlar.Add(yeni);
            db.SaveChanges();
            return View("Index");
        }

        public JsonResult FillDers()
        {
            List<Ders> Dersler = db.Dersler.ToList();
            string html="";
            foreach (var item in Dersler)
            {
              html+= "<option value='"+item.Kod+"'>"+item.Name+"</option>";
            }

            return Json(new{message=html },JsonRequestBehavior.AllowGet);
        }

        public JsonResult FillSagird()
        {
            List<Sagird> Sagirdler = db.Sagirdler.ToList();
            string html = "";
            foreach (var item in Sagirdler)
            {
                html += "<option value='" + item.Nomre + "'>" + item.Name +" "+item.Surname+ "</option>";
            }

            return Json(new { message = html }, JsonRequestBehavior.AllowGet);
        }
    }
}