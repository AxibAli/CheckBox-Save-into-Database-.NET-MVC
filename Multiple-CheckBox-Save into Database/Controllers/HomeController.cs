using Multiple_CheckBox_Save_into_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multiple_CheckBox_Save_into_Database.Controllers
{
    public class HomeController : Controller
    {
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
        [HttpGet]
        public ActionResult CheckBoxWork() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckBoxWork(CheckboxModel CBM)
        {
            return View();
        }
    }
}