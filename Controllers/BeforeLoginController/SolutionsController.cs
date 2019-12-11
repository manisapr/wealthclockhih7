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
    public class SolutionsController : Controller
    {
        // GET: Solutions
        public ActionResult Index()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);           
            rdr.Fill(ds);

            ViewBag.position66 = ds.Tables[0].Rows[62]["Title"].ToString();
            ViewBag.position67 = ds.Tables[0].Rows[73]["Description"].ToString();
            ViewBag.position68 = ds.Tables[0].Rows[63]["Title"].ToString();
            ViewBag.position69 = ds.Tables[0].Rows[74]["Description"].ToString();
            ViewBag.position70 = ds.Tables[0].Rows[64]["Title"].ToString();
            ViewBag.position71 = ds.Tables[0].Rows[75]["Description"].ToString();
            ViewBag.position72 = ds.Tables[0].Rows[65]["Title"].ToString();
            ViewBag.position73 = ds.Tables[0].Rows[76]["Description"].ToString();
            ViewBag.position74 = ds.Tables[0].Rows[66]["Title"].ToString();
            ViewBag.position75 = ds.Tables[0].Rows[77]["Description"].ToString();
           


            return View();
        }

        public ActionResult FinancialPlanning()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position76 = ds.Tables[0].Rows[67]["Title"].ToString();
            ViewBag.position77 = ds.Tables[0].Rows[78]["Description"].ToString();
            ViewBag.position78 = ds.Tables[0].Rows[79]["Description"].ToString();
            ViewBag.position79 = ds.Tables[0].Rows[80]["Description"].ToString();
            ViewBag.position80 = ds.Tables[0].Rows[84]["Description"].ToString();
            ViewBag.position81 = ds.Tables[0].Rows[85]["Description"].ToString();
            ViewBag.position82 = ds.Tables[0].Rows[86]["Description"].ToString();
            ViewBag.position83 = ds.Tables[0].Rows[68]["Description"].ToString();
            ViewBag.position84 = ds.Tables[0].Rows[69]["Description"].ToString();
            ViewBag.position85 = ds.Tables[0].Rows[87]["Description"].ToString();
            ViewBag.position86 = ds.Tables[0].Rows[88]["Description"].ToString();
            ViewBag.position87 = ds.Tables[0].Rows[81]["Description"].ToString();


            return View();
        }

        public ActionResult RetirementPlanning()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position88 = ds.Tables[0].Rows[82]["Title"].ToString();
            ViewBag.position89 = ds.Tables[0].Rows[89]["Description"].ToString();
            ViewBag.position90 = ds.Tables[0].Rows[83]["Description"].ToString();
            ViewBag.position91 = ds.Tables[0].Rows[90]["Title"].ToString();
            ViewBag.position92 = ds.Tables[0].Rows[91]["Description"].ToString();
            ViewBag.position93 = ds.Tables[0].Rows[92]["Title"].ToString();
            ViewBag.position94 = ds.Tables[0].Rows[93]["Description"].ToString();
            ViewBag.position95 = ds.Tables[0].Rows[94]["Title"].ToString();
            ViewBag.position96 = ds.Tables[0].Rows[95]["Description"].ToString();
            ViewBag.position97 = ds.Tables[0].Rows[96]["Title"].ToString();
            ViewBag.position98 = ds.Tables[0].Rows[97]["Description"].ToString();
            ViewBag.position99 = ds.Tables[0].Rows[102]["Description"].ToString();
            ViewBag.position100 = ds.Tables[0].Rows[103]["Description"].ToString();
            ViewBag.position101 = ds.Tables[0].Rows[104]["Description"].ToString();

            return View();
        }

        public ActionResult GoalPlanning()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position102 = ds.Tables[0].Rows[105]["Title"].ToString();
            ViewBag.position103 = ds.Tables[0].Rows[106]["Description"].ToString();
            ViewBag.position104 = ds.Tables[0].Rows[107]["Title"].ToString();
            ViewBag.position105 = ds.Tables[0].Rows[108]["Description"].ToString();
            ViewBag.position106 = ds.Tables[0].Rows[109]["Description"].ToString();
            ViewBag.position107 = ds.Tables[0].Rows[110]["Description"].ToString();
            ViewBag.position108 = ds.Tables[0].Rows[111]["Title"].ToString();
            ViewBag.position109 = ds.Tables[0].Rows[120]["Description"].ToString();
            ViewBag.position110 = ds.Tables[0].Rows[121]["Description"].ToString();
            ViewBag.position111 = ds.Tables[0].Rows[122]["Description"].ToString();
            ViewBag.position112 = ds.Tables[0].Rows[112]["Title"].ToString();
            ViewBag.position113 = ds.Tables[0].Rows[123]["Description"].ToString();
            ViewBag.position114 = ds.Tables[0].Rows[113]["Description"].ToString();
            ViewBag.position115 = ds.Tables[0].Rows[114]["Title"].ToString();


            return View();
        }

        public ActionResult TaxPlanning()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position116 = ds.Tables[0].Rows[115]["Title"].ToString();
            ViewBag.position117 = ds.Tables[0].Rows[124]["Description"].ToString();
            ViewBag.position118 = ds.Tables[0].Rows[125]["Title"].ToString();
            ViewBag.position119 = ds.Tables[0].Rows[126]["Title"].ToString();
            ViewBag.position120 = ds.Tables[0].Rows[127]["Title"].ToString();
            ViewBag.position121 = ds.Tables[0].Rows[128]["Description"].ToString();
            ViewBag.position122 = ds.Tables[0].Rows[129]["Title"].ToString();
            ViewBag.position123 = ds.Tables[0].Rows[130]["Description"].ToString();
            ViewBag.position124 = ds.Tables[0].Rows[131]["Title"].ToString();
            ViewBag.position125 = ds.Tables[0].Rows[132]["Description"].ToString();
            ViewBag.position126 = ds.Tables[0].Rows[133]["Description"].ToString();
            ViewBag.position127 = ds.Tables[0].Rows[134]["Description"].ToString();
            ViewBag.position128 = ds.Tables[0].Rows[135]["Title"].ToString();
            ViewBag.position129 = ds.Tables[0].Rows[141]["Description"].ToString();
            ViewBag.position130 = ds.Tables[0].Rows[136]["Description"].ToString();

            return View();
        }
    }
}