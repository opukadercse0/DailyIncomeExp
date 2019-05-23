using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyIncomeExp.DataAccess;
using DailyIncomeExp.Models;

namespace DailyIncomeExp.DataManager
{
    public class CountryManager
    {
        public List<CountryModel> LoadCountry()
        {
            string sql = "Select * From Country";
            return SqlDataAccess.LoadData<CountryModel>(sql);
        }
    }
}