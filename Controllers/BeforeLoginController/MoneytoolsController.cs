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
    public class MoneytoolsController : Controller
    {
        // GET: Moneytools
        public ActionResult Index()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position133 = ds.Tables[0].Rows[138]["Title"].ToString();
            ViewBag.position134 = ds.Tables[0].Rows[139]["Title"].ToString();
            ViewBag.position135 = ds.Tables[0].Rows[140]["Description"].ToString();



            return View();
        }

        public ActionResult SIPCalculator()
        {


            return View();
        }

        public ActionResult AssetAllocation()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);


            ViewBag.position136 = ds.Tables[0].Rows[98]["Title"].ToString();
            ViewBag.position137 = ds.Tables[0].Rows[143]["Description"].ToString();
            ViewBag.position138 = ds.Tables[0].Rows[99]["Title"].ToString();
            ViewBag.position139 = ds.Tables[0].Rows[100]["Description"].ToString();
            ViewBag.position140 = ds.Tables[0].Rows[144]["Description"].ToString();

            return View();
        }

        public ActionResult CuttingExtraExpenses()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);


            ViewBag.position141 = ds.Tables[0].Rows[101]["Title"].ToString();
            ViewBag.position142 = ds.Tables[0].Rows[145]["Description"].ToString();
            ViewBag.position143 = ds.Tables[0].Rows[146]["Title"].ToString();

            return View();
        }

        public ActionResult RiskAnalyzer()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position144 = ds.Tables[0].Rows[116]["Title"].ToString();
            ViewBag.position145 = ds.Tables[0].Rows[158]["Description"].ToString();
            ViewBag.position146 = ds.Tables[0].Rows[159]["Title"].ToString();


            return View();
        }

        public ActionResult GoodTimeToInvest()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position147 = ds.Tables[0].Rows[160]["Title"].ToString();
            ViewBag.position148 = ds.Tables[0].Rows[161]["Description"].ToString();
            ViewBag.position149 = ds.Tables[0].Rows[162]["Title"].ToString();
            ViewBag.position150 = ds.Tables[0].Rows[163]["Title"].ToString();
            ViewBag.position151 = ds.Tables[0].Rows[164]["Title"].ToString();
            ViewBag.position152 = ds.Tables[0].Rows[165]["Description"].ToString();
            ViewBag.position153 = ds.Tables[0].Rows[166]["Title"].ToString();
            ViewBag.position154 = ds.Tables[0].Rows[167]["Title"].ToString();
            ViewBag.position155 = ds.Tables[0].Rows[168]["Description"].ToString();



            return View();
        }

        public ActionResult DelayedSIP()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position156 = ds.Tables[0].Rows[169]["Title"].ToString();
            ViewBag.position157 = ds.Tables[0].Rows[170]["Description"].ToString();
            ViewBag.position158 = ds.Tables[0].Rows[171]["Title"].ToString();



            return View();
        }

        public ActionResult RightAmountForYourSIP()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position159 = ds.Tables[0].Rows[172]["Title"].ToString();
            ViewBag.position160 = ds.Tables[0].Rows[173]["Description"].ToString();
            ViewBag.position161 = ds.Tables[0].Rows[174]["Title"].ToString();
            ViewBag.position162 = ds.Tables[0].Rows[175]["Title"].ToString();




            return View();
        }
    }
}