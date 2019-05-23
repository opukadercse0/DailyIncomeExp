using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DailyIncomeExp.Controllers
{
    public class UserController : Controller
    {
        //Registration
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        //Login
       
    }
}