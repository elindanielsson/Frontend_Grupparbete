﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Grupparbete.Controllers
{
    public class ClockController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Nav = "Clock";
            return View();
    
        }
    }
}