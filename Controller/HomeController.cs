using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Studentgrade.Models;

namespace Grade.Controllers
{
    public class HomeController : Controller
    {
   
        [HttpGet]
        public ActionResult Index()
        {
           return View(); 
         


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult index (Class1 model)
        {
         

            if (ModelState.IsValid)
            {
                var java = model.java;
                var lb = model.lb;
                var sql = model.sql;
                var excel = model.excel;
                var andriod = model.andriod;
                TempData["tota"] = java + lb + excel + andriod + java;
                var avg= (java + lb + excel + andriod + java)/5;
                TempData["avg"] = avg.ToString("0.00");
                if (java >= 0 && java <= 39) { TempData["java"] = "failure"; }
                if (java >= 40 && java <= 59) { TempData["java"] = "Satisfactory"; }
                if (java >= 60 && java <= 69) { TempData["java"] = "Good"; }
                if (java >= 70 && java <= 79) { TempData["java"] = "Very Good"; }
                if (java >= 80 && java <= 89) { TempData["java"] = "Excellent"; }
                if (java >= 90 && java <= 100) { TempData["java"] = "Distinction"; }

                if (lb >= 0 && lb <= 39) { TempData["lb"] = "failure"; }
                if (lb >= 40 && lb <= 59) { TempData["lb"] = "Satisfactory"; }
                if (lb >= 60 && lb <= 69) { TempData["lb"] = "Good"; }
                if (lb >= 70 && lb <= 79) { TempData["lb"] = "Very Good"; }
                if (lb >= 80 && lb <= 89) { TempData["lb"] = "Excellent"; }
                if (lb >= 90 && lb <= 100) { TempData["lb"] = "Distinction"; }

                if (andriod >= 0 && andriod <= 39) { TempData["andriod"] = "failure"; }
                if (andriod >= 40 && andriod <= 59) { TempData["andriod"] = "Satisfactory"; }
                if (andriod >= 60 && andriod <= 69) { TempData["andriod"] = "Good"; }
                if (andriod >= 70 && andriod <= 79) { TempData["andriod"] = "Very Good"; }
                if (andriod >= 80 && andriod <= 89) { TempData["andriod"] = "Excellent"; }
                if (andriod >= 90 && andriod <= 100) { TempData["andriod"] = "Distinction"; }

                if (excel >= 0 && excel <= 39) { TempData["excel"] = "failure"; }
                if (excel >= 40 && excel <= 59) { TempData["excel"] = "Satisfactory"; }
                if (excel >= 60 && excel <= 69) { TempData["excel"] = "Good"; }
                if (excel >= 70 && excel <= 79) { TempData["excel"] = "Very Good"; }
                if (excel >= 80 && excel <= 89) { TempData["excel"] = "Excellent"; }
                if (excel >= 90 && excel <= 100) { TempData["excel"] = "Distinction"; }

                if (sql >= 0 && sql <= 39) { TempData["sql"] = "failure"; }
                if (sql >= 40 && sql <= 59) { TempData["sql"] = "Satisfactory"; }
                if (sql >= 60 && sql <= 69) { TempData["sql"] = "Good"; }
                if (sql >= 70 && sql <= 79) { TempData["sql"] = "Very Good"; }
                if (sql >= 80 && sql <= 89) { TempData["sql"] = "Excellent"; }
                if (sql >= 90 && sql <= 100) { TempData["sql"] = "Distinction"; }

                if (avg >= 0 && avg <= 39) { TempData["class"] = "fail"; }
                if (avg >= 40 && avg <= 59) { TempData["class"] = "pass"; }
                if (avg >= 60 && avg <= 69) { TempData["class"] = "third class"; }
                if (avg >= 70 && avg <= 79) { TempData["class"] = "second class lower"; }
                if (avg >= 80 && avg <= 89) { TempData["class"] = "second class upper"; }
                if (avg >= 90 && avg <= 100) { TempData["class"] = "first class"; }

             



                var points = 0;
                String[] array = new String[3];
                array[0] = "";
                array[1] = "failed";
                array[2] = "passed";

                if (avg< 50) points++; 
                if (avg >= 50) { points++; points++;  }
                TempData["desc"] = array[points];
                TempData["ccs"] = points;
            



                return RedirectToAction("Contact", "Home");
            }

           
            // { //return View(model); }

            return View(model);
        }
    public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(Class1 model)
        {
           
 
            return View(model);
        }
 
}

}