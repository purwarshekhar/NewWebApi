﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiDemo.Controllers.API
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult GetStudentName2()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult GetNewStudentData()
        {
            ViewBag.Title = "GetNewStudentData Page";

            return View();
        }

        public ActionResult GetNewStudentData2()
        {
            ViewBag.Title = "GetNewStudentData Page";

            return View();
        }

        public ActionResult GetNewStudentData3()
        {
            ViewBag.Title = "Rebase 3 Page";

            return View();
        }
    }
}
