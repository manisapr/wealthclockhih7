using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WealthClock_25_11_2019_NEW.Controllers.BeforeLoginController
{
    public class WealthclockPicksController : Controller
    {
        // GET: WealthclockPicks
        public ActionResult Index()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position131 = ds.Tables[0].Rows[137]["Title"].ToString();
            ViewBag.position132 = ds.Tables[0].Rows[142]["Description"].ToString();




            return View();
        }
    }
}