using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using WealthClock_25_11_2019_NEW.Models;
using WealthClock_25_11_2019_NEW.CodeFile;

namespace WealthClock_25_11_2019_NEW.Controllers.BeforeLoginController
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Home Dynamic//
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);
            ViewBag.position1 = ds.Tables[0].Rows[0]["Title"].ToString();
            ViewBag.position2 = ds.Tables[0].Rows[1]["Title"].ToString();
            ViewBag.position3 = ds.Tables[0].Rows[2]["Description"].ToString();
            ViewBag.position4 = ds.Tables[0].Rows[3]["Title"].ToString();
            ViewBag.position5 = ds.Tables[0].Rows[4]["Title"].ToString();
            ViewBag.position6 = ds.Tables[0].Rows[5]["Description"].ToString();
            ViewBag.position7 = ds.Tables[0].Rows[6]["Title"].ToString();
            ViewBag.position8 = ds.Tables[0].Rows[7]["Title"].ToString();
            ViewBag.position9 = ds.Tables[0].Rows[8]["Description"].ToString();
            ViewBag.position10 = ds.Tables[0].Rows[9]["Title"].ToString();
            ViewBag.position11 = ds.Tables[0].Rows[10]["Description"].ToString();
            ViewBag.position12 = ds.Tables[0].Rows[11]["Title"].ToString();
            ViewBag.position13 = ds.Tables[0].Rows[12]["Description"].ToString();
            ViewBag.position14 = ds.Tables[0].Rows[13]["Title"].ToString();
            ViewBag.position15 = ds.Tables[0].Rows[14]["Title"].ToString();
            ViewBag.position16 = ds.Tables[0].Rows[15]["Description"].ToString();
            ViewBag.position17 = ds.Tables[0].Rows[16]["Title"].ToString();
            ViewBag.position18 = ds.Tables[0].Rows[17]["Description"].ToString();
            ViewBag.position19 = ds.Tables[0].Rows[18]["Title"].ToString();
            ViewBag.position20 = ds.Tables[0].Rows[19]["Description"].ToString();
            ViewBag.position21 = ds.Tables[0].Rows[20]["Title"].ToString();
            ViewBag.position22 = ds.Tables[0].Rows[21]["Description"].ToString();
            ViewBag.position23 = ds.Tables[0].Rows[22]["Title"].ToString();
            ViewBag.position24 = ds.Tables[0].Rows[23]["Description"].ToString();
            ViewBag.position25 = ds.Tables[0].Rows[24]["Title"].ToString();
            ViewBag.position26 = ds.Tables[0].Rows[25]["Description"].ToString();
            ViewBag.position27 = ds.Tables[0].Rows[26]["Title"].ToString();
            ViewBag.position28 = ds.Tables[0].Rows[27]["Description"].ToString();
            ViewBag.position29 = ds.Tables[0].Rows[28]["Title"].ToString();
            ViewBag.position30 = ds.Tables[0].Rows[29]["Description"].ToString();
            ViewBag.position31 = ds.Tables[0].Rows[30]["Title"].ToString();
            ViewBag.position32 = ds.Tables[0].Rows[31]["Description"].ToString();
            ViewBag.position33 = ds.Tables[0].Rows[32]["Title"].ToString();
            ViewBag.position34 = ds.Tables[0].Rows[33]["Description"].ToString();
            ViewBag.position35 = ds.Tables[0].Rows[34]["Title"].ToString();
            ViewBag.position36 = ds.Tables[0].Rows[35]["Description"].ToString();
            ViewBag.position37 = ds.Tables[0].Rows[36]["Title"].ToString();
            ViewBag.position38 = ds.Tables[0].Rows[37]["Description"].ToString();
            ViewBag.position39 = ds.Tables[0].Rows[38]["Title"].ToString();
            ViewBag.position40 = ds.Tables[0].Rows[39]["Description"].ToString();
            ViewBag.position41 = ds.Tables[0].Rows[40]["Title"].ToString();
            ViewBag.position42 = ds.Tables[0].Rows[41]["Description"].ToString();
            ViewBag.position43 = ds.Tables[0].Rows[42]["Title"].ToString();
            ViewBag.position44 = ds.Tables[0].Rows[43]["Description"].ToString();
            ViewBag.position45 = ds.Tables[0].Rows[44]["Title"].ToString();
            ViewBag.position46 = ds.Tables[0].Rows[45]["Description"].ToString();
            ViewBag.position47 = ds.Tables[0].Rows[46]["Title"].ToString();
            ViewBag.position48 = ds.Tables[0].Rows[47]["Description"].ToString();
            ViewBag.position49 = ds.Tables[0].Rows[48]["Title"].ToString();
            ViewBag.position50 = ds.Tables[0].Rows[49]["Description"].ToString();
            ViewBag.position51 = ds.Tables[0].Rows[50]["Title"].ToString();
            ViewBag.position52 = ds.Tables[0].Rows[51]["Description"].ToString();
            ViewBag.position53 = ds.Tables[0].Rows[52]["Title"].ToString();
            ViewBag.position54 = ds.Tables[0].Rows[53]["Description"].ToString();
            ViewBag.position55 = ds.Tables[0].Rows[54]["Title"].ToString();
            ViewBag.position56 = ds.Tables[0].Rows[55]["Description"].ToString();
            ViewBag.position57 = ds.Tables[0].Rows[56]["Title"].ToString();
            ViewBag.position58 = ds.Tables[0].Rows[57]["Description"].ToString();
            ViewBag.position59 = ds.Tables[0].Rows[58]["Title"].ToString();
            ViewBag.position60 = ds.Tables[0].Rows[70]["Description"].ToString();
            ViewBag.position61 = ds.Tables[0].Rows[59]["Title"].ToString();
            ViewBag.position62 = ds.Tables[0].Rows[71]["Description"].ToString();
            ViewBag.position63 = ds.Tables[0].Rows[60]["Title"].ToString();
            ViewBag.position64 = ds.Tables[0].Rows[72]["Description"].ToString();
            ViewBag.position65 = ds.Tables[0].Rows[61]["Title"].ToString();


            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }

        public ActionResult Disclosure()
        {
            return View();
        }

        public JsonResult RequestCallBack(string Name, string Email, string Mobile, string PrefDate, string PrefTime, string Message)
        {
            myAccountCode objMyAccount = new myAccountCode();
            string response = "";
            if (objMyAccount.InsertRequstCallBackData(Name, Email, Mobile, PrefDate, PrefTime, Message) > 0)
            {
                response = "Success|Request has been successfully submit";
            }
            else
            {
                response = "Failed|Error Occured";
            }
            return Json(response, JsonRequestBehavior.AllowGet);

        }



    }
}