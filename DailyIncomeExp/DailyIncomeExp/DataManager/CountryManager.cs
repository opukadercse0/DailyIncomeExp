using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyIncomeExp.DataAccess;
using DailyIncomeExp.Models;

namespace DailyIncomeExp.DataManager
{
    public static class CountryManager
    {
        public static List<CountryModel> LoadCountry()
        {
            string sql = "SELECT * FROM Country";
            return SqlDataAccess.LoadData<CountryModel>(sql);
        }
    }
}