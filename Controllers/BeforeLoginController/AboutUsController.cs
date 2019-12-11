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
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position212 = ds.Tables[0].Rows[222]["Title"].ToString();
            ViewBag.position213 = ds.Tables[0].Rows[223]["Description"].ToString();
            ViewBag.position214 = ds.Tables[0].Rows[224]["Description"].ToString();
            ViewBag.position215 = ds.Tables[0].Rows[228]["Description"].ToString();
            ViewBag.position216 = ds.Tables[0].Rows[229]["Description"].ToString();
            ViewBag.position217 = ds.Tables[0].Rows[230]["Description"].ToString();
            ViewBag.position218 = ds.Tables[0].Rows[231]["Description"].ToString();
            ViewBag.position219 = ds.Tables[0].Rows[232]["Description"].ToString();
            ViewBag.position220 = ds.Tables[0].Rows[233]["Description"].ToString();
            ViewBag.position221 = ds.Tables[0].Rows[234]["Description"].ToString();
            ViewBag.position222 = ds.Tables[0].Rows[225]["Title"].ToString();
            ViewBag.position223 = ds.Tables[0].Rows[235]["Description"].ToString();
            ViewBag.position224 = ds.Tables[0].Rows[226]["Title"].ToString();
            ViewBag.position225 = ds.Tables[0].Rows[227]["Description"].ToString();
            ViewBag.position226 = ds.Tables[0].Rows[236]["Title"].ToString();
            ViewBag.position227 = ds.Tables[0].Rows[237]["Description"].ToString();
            ViewBag.position228 = ds.Tables[0].Rows[238]["Title"].ToString();
            ViewBag.position229 = ds.Tables[0].Rows[239]["Description"].ToString();
            ViewBag.position230 = ds.Tables[0].Rows[240]["Title"].ToString();
            ViewBag.position231 = ds.Tables[0].Rows[241]["Description"].ToString();


            return View();
        }

        public ActionResult WhyUs()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position232 = ds.Tables[0].Rows[242]["Title"].ToString();
            ViewBag.position233 = ds.Tables[0].Rows[243]["Description"].ToString();
            ViewBag.position234 = ds.Tables[0].Rows[244]["Title"].ToString();
            ViewBag.position235 = ds.Tables[0].Rows[245]["Description"].ToString();
            ViewBag.position236 = ds.Tables[0].Rows[246]["Description"].ToString();
            ViewBag.position237 = ds.Tables[0].Rows[247]["Description"].ToString();
            ViewBag.position238 = ds.Tables[0].Rows[248]["Title"].ToString();
            ViewBag.position239 = ds.Tables[0].Rows[249]["Description"].ToString();
            ViewBag.position240 = ds.Tables[0].Rows[250]["Description"].ToString();
            ViewBag.position241 = ds.Tables[0].Rows[251]["Title"].ToString();
            ViewBag.position242 = ds.Tables[0].Rows[252]["Description"].ToString();
            ViewBag.position243 = ds.Tables[0].Rows[253]["Description"].ToString();
            ViewBag.position244 = ds.Tables[0].Rows[254]["Description"].ToString();
            ViewBag.position245 = ds.Tables[0].Rows[255]["Title"].ToString();
            ViewBag.position246 = ds.Tables[0].Rows[256]["Description"].ToString();
            ViewBag.position247 = ds.Tables[0].Rows[257]["Description"].ToString();
            ViewBag.position248 = ds.Tables[0].Rows[258]["Description"].ToString();
            ViewBag.position249 = ds.Tables[0].Rows[259]["Title"].ToString();
            ViewBag.position250 = ds.Tables[0].Rows[260]["Description"].ToString();
            ViewBag.position251 = ds.Tables[0].Rows[261]["Description"].ToString();
            ViewBag.position252 = ds.Tables[0].Rows[262]["Title"].ToString();
            ViewBag.position253 = ds.Tables[0].Rows[263]["Description"].ToString();
            ViewBag.position254 = ds.Tables[0].Rows[264]["Description"].ToString();
            ViewBag.position255 = ds.Tables[0].Rows[265]["Description"].ToString();





            return View();
        }

        public ActionResult HowItWorks()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand com = new SqlCommand("select * from frontendpagestructure", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter rdr = new SqlDataAdapter(com);
            rdr.Fill(ds);

            ViewBag.position256 = ds.Tables[0].Rows[147]["Title"].ToString();
            ViewBag.position257 = ds.Tables[0].Rows[148]["Description"].ToString();
            ViewBag.position258 = ds.Tables[0].Rows[149]["Title"].ToString();
            ViewBag.position259 = ds.Tables[0].Rows[150]["Description"].ToString();
            ViewBag.position260 = ds.Tables[0].Rows[151]["Title"].ToString();
            ViewBag.position261 = ds.Tables[0].Rows[152]["Description"].ToString();
            ViewBag.position262 = ds.Tables[0].Rows[153]["Description"].ToString();
            ViewBag.position263 = ds.Tables[0].Rows[154]["Description"].ToString();
            ViewBag.position264 = ds.Tables[0].Rows[155]["Title"].ToString();
            ViewBag.position265 = ds.Tables[0].Rows[156]["Description"].ToString();
            ViewBag.position266 = ds.Tables[0].Rows[157]["Title"].ToString();
            ViewBag.position267 = ds.Tables[0].Rows[266]["Description"].ToString();
            ViewBag.position268 = ds.Tables[0].Rows[267]["Title"].ToString();
            ViewBag.position269 = ds.Tables[0].Rows[268]["Description"].ToString();
            ViewBag.position270 = ds.Tables[0].Rows[269]["Title"].ToString();
            ViewBag.position271 = ds.Tables[0].Rows[270]["Description"].ToString();
            ViewBag.position272 = ds.Tables[0].Rows[271]["Title"].ToString();
            ViewBag.position273 = ds.Tables[0].Rows[272]["Description"].ToString();
            ViewBag.position274 = ds.Tables[0].Rows[273]["Description"].ToString();
            ViewBag.position275 = ds.Tables[0].Rows[274]["Description"].ToString();
            ViewBag.position276 = ds.Tables[0].Rows[275]["Description"].ToString();

            return View();
        }
    }
}