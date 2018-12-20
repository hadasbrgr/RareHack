using hakaton.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace hakaton.Controllers
{
    public class HomeController : Controller
    {
        static List<Info> Prog;
        static ProgInfo pg;
        public HomeController()
        {
            pg = new ProgInfo();
            Prog = pg.listInfo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult History()
        {
            ViewBag.listOfUsersInfo = pg.listInfo;
            return View(pg);
        }


        public ActionResult Try()
        {
            ViewBag.age =//model new List<string> { "5", "6" };
            ViewBag.gender= new List<string> { "Male", "Female" };
            return View();
        }

        [HttpPost]
        public ActionResult Sol(String FirstName, String LastName, String Id, String Gender, String Date, String Q1, String Q2, String Q3, String Q4)
        {
            string mydocpath = Id + ";" + FirstName + ";" + LastName + ";" + Gender + ";" + Date + ";";
            StreamWriter sw = new StreamWriter((System.IO.File.Open(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ProgInformation.txt"), System.IO.FileMode.Append)));
            sw.WriteLine(mydocpath);
            sw.Close();
            pg.listInfo.Add(new Info() { ID = Convert.ToInt32(Id), firstName = FirstName, lastName = LastName, gender = Gender, birthDate = Date });
            return Json(true);
        }

        public ActionResult Sol2(String Id, String text1)
        {
            string mydocpath = Id + ";" + text1+";";
            StreamWriter sw = new StreamWriter((System.IO.File.Open(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/freeText.txt"), System.IO.FileMode.Append)));
            sw.WriteLine(mydocpath);
            sw.Close();
            return Json(true);
        }

        private void exportInfo()
        {
            string data = "Col1, Col2, Col2";
            string filePath = @"File.csv";
            System.IO.File.WriteAllText(filePath, data);
            string dataFromRead = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(dataFromRead);
        }

        public ActionResult Gide(string page)
        {

            if (page == null)
            {
                ViewBag.page = "1";
            }
            else
            {
                ViewBag.page = page;
            }
            return View();
        }
    }
}