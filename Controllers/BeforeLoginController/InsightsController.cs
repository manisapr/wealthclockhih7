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
    public class InsightsController : Controller
    {
        // GET: Insights
        public ActionResult Index()
        {


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);


            ViewBag.position163 = ds.Tables[0].Rows[176]["Title"].ToString();
            ViewBag.position164 = ds.Tables[0].Rows[177]["Title"].ToString();
            ViewBag.position165 = ds.Tables[0].Rows[178]["Description"].ToString();
            ViewBag.position166 = ds.Tables[0].Rows[179]["Title"].ToString();
            ViewBag.position167 = ds.Tables[0].Rows[180]["Description"].ToString();
            ViewBag.position168 = ds.Tables[0].Rows[181]["Title"].ToString();
            ViewBag.position169 = ds.Tables[0].Rows[182]["Description"].ToString();
            ViewBag.position170 = ds.Tables[0].Rows[183]["Title"].ToString();
            ViewBag.position171 = ds.Tables[0].Rows[184]["Description"].ToString();
            ViewBag.position172 = ds.Tables[0].Rows[185]["Title"].ToString();
            ViewBag.position173 = ds.Tables[0].Rows[186]["Description"].ToString();


            return View();
        }

        public ActionResult Blog()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position174 = ds.Tables[0].Rows[187]["Title"].ToString();
            ViewBag.position175 = ds.Tables[0].Rows[188]["Title"].ToString();
            ViewBag.position176 = ds.Tables[0].Rows[189]["Description"].ToString();
            ViewBag.position177 = ds.Tables[0].Rows[190]["Description"].ToString();
            ViewBag.position178 = ds.Tables[0].Rows[191]["Description"].ToString();
            ViewBag.position179 = ds.Tables[0].Rows[192]["Description"].ToString();
            ViewBag.position180 = ds.Tables[0].Rows[193]["Description"].ToString();
            ViewBag.position181 = ds.Tables[0].Rows[194]["Description"].ToString();
            ViewBag.position182 = ds.Tables[0].Rows[117]["Description"].ToString();
            ViewBag.position183 = ds.Tables[0].Rows[118]["Description"].ToString();
            ViewBag.position184 = ds.Tables[0].Rows[119]["Description"].ToString();
            ViewBag.position185 = ds.Tables[0].Rows[195]["Description"].ToString();
            ViewBag.position186 = ds.Tables[0].Rows[196]["Description"].ToString();
            ViewBag.position187 = ds.Tables[0].Rows[197]["Description"].ToString();
            ViewBag.position188 = ds.Tables[0].Rows[198]["Description"].ToString();
            ViewBag.position189 = ds.Tables[0].Rows[199]["Description"].ToString();
            ViewBag.position190 = ds.Tables[0].Rows[200]["Description"].ToString();
            ViewBag.position191 = ds.Tables[0].Rows[201]["Description"].ToString();
            ViewBag.position192 = ds.Tables[0].Rows[202]["Description"].ToString();
            ViewBag.position193 = ds.Tables[0].Rows[203]["Description"].ToString();
            ViewBag.position194 = ds.Tables[0].Rows[204]["Description"].ToString();
            ViewBag.position195 = ds.Tables[0].Rows[205]["Description"].ToString();
            ViewBag.position196 = ds.Tables[0].Rows[206]["Description"].ToString();
            ViewBag.position197 = ds.Tables[0].Rows[207]["Description"].ToString();
            ViewBag.position198 = ds.Tables[0].Rows[208]["Description"].ToString();
            ViewBag.position199 = ds.Tables[0].Rows[209]["Description"].ToString();
            ViewBag.position200 = ds.Tables[0].Rows[210]["Description"].ToString();
            ViewBag.position201 = ds.Tables[0].Rows[211]["Description"].ToString();
            ViewBag.position202 = ds.Tables[0].Rows[212]["Description"].ToString();
            ViewBag.position203 = ds.Tables[0].Rows[213]["Description"].ToString();
            ViewBag.position204 = ds.Tables[0].Rows[214]["Description"].ToString();
            ViewBag.position205 = ds.Tables[0].Rows[215]["Description"].ToString();
            ViewBag.position206 = ds.Tables[0].Rows[216]["Description"].ToString();
            ViewBag.position207 = ds.Tables[0].Rows[217]["Description"].ToString();
            ViewBag.position208 = ds.Tables[0].Rows[218]["Description"].ToString();
            ViewBag.position209 = ds.Tables[0].Rows[219]["Description"].ToString();
            ViewBag.position210 = ds.Tables[0].Rows[220]["Description"].ToString();
            ViewBag.position211 = ds.Tables[0].Rows[221]["Description"].ToString();


            return View();
        }

        public ActionResult KnowledgeBytes()
        {
            return View();
        }

        public ActionResult Infographic()
        {
            return View();
        }

        public ActionResult Trending()
        {
            return View();
        }
    }
}