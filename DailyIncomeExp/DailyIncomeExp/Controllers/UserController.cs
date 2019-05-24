using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyIncomeExp.DataManager;
using DailyIncomeExp.Models;
using DailyIncomeExp.Models.ViewModel;

namespace DailyIncomeExp.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
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
            //password hashing
            data.Password = Crypto.Hash(data.Password);
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
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(LogInViewModel login)
        {
            login.Password = Crypto.Hash(login.Password);
            CompanyModel data=LogInManager.ValidateLogin(login);
            if (data !=null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Log In Invalid";
                ModelState.AddModelError("InvalidLogIn","Ivalid log In Information");
            }
            return View();
        }

        //log out
        public ActionResult LogOut()
        {
            return RedirectToAction("LogIn", "User");
        }

    }
}