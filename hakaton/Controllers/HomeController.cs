using hakaton.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace hakaton.Controllers
{
    public class HomeController : Controller
    {
        static Info Prog;

        public HomeController()
        {
            ProgInfo pg = new ProgInfo();
            Prog = pg.Info;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Try()
        {
            ViewBag.age = new List<string> { "5", "6" };
            ViewBag.gender= new List<string> { "Male", "Female" };
            return View();
        }

        [HttpPost]
        public ActionResult Sol(String gender, String age)
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