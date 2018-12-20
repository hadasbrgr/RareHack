using hakaton.Models;
using System;
using System.Collections.Generic;
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
            Session["abstain_help"] = "avoid";
            Session["voters"] = 0;
            exportInfo();
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