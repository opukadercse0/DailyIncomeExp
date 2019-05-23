using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyIncomeExp.DataManager;

namespace DailyIncomeExp.Controllers
{
    public class UserController : Controller
    {
        //Registration
        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.CountryList = CountryManager.LoadCountry();
            return View();
        }
        //Login
       
    }
}