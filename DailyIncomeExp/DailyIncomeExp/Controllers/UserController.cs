using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyIncomeExp.DataManager;
using DailyIncomeExp.Models;

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
       
        [HttpPost]
        public ActionResult Registration(CompanyModel data)

        {
            bool issSaved=CompanyManager.SaveCompany(data);
            if (issSaved)
            {
                ViewBag.Message = "Your Registration Completed!";
                return View();
            }
            ViewBag.CountryList = CountryManager.LoadCountry();
            return View();
        }

        //Login

    }
}