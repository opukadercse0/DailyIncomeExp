using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyIncomeExp.DataAccess;
using DailyIncomeExp.Models;

namespace DailyIncomeExp.DataManager
{
    public static class CompanyManager
    {
        public static bool SaveCompany(CompanyModel data)
        {
            string sql = "INSERT INTO Company(CompanyName,CompanyEmail,Password,Address,CountryId)"
                         + " VALUES(@CompanyName,@CompanyEmail,@Password,@Address,@CountryId)";
            int rowAffected=SqlDataAccess.SaveData<CompanyModel>(sql,data);
            if (rowAffected>0)
            {
                return true;
            }

            return false;
        }
    }
}