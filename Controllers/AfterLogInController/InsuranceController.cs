﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WealthClock_25_11_2019_NEW.Controllers.AfterLogInController
{
    public class InsuranceController : Controller
    {
        // GET: Financialinfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Insurance()
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("index", "home");
            }
        }
    }
}