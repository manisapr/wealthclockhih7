using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WealthClock_25_11_2019_NEW.Controllers.AfterLogInController
{
    public class MutualFundController : Controller
    {
        // GET: MutualFund
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WealthclockRecomended()
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
        public ActionResult SmartDeposit()
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
        public ActionResult PortfolioView()
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
        public ActionResult ActiveSystematicPlans()
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
        public ActionResult TransactionHistory()
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
        public ActionResult AddDeleteFamilyMember()
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
        public ActionResult FamilyAccountView()
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