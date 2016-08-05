using HomeWork1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RecordLoginViewModel pagedata)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult RecordTableRow()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult RecordTable()
        {
            return View();
        }
    }
}