using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Globalization;
using WealthClock_25_11_2019_NEW.CodeFile;
using WealthClock_25_11_2019_NEW.Models;


namespace WealthClock_25_11_2019_NEW.Controllers.BeforeLoginController
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs

       
        public ActionResult Index()
        {

            return View();     
        }

    }
}