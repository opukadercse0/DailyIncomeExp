using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyIncomeExp.DataAccess;
using DailyIncomeExp.Models;
using DailyIncomeExp.Models.ViewModel;

namespace DailyIncomeExp.DataManager
{
    public static class LogInManager
    {
        public static CompanyModel ValidateLogin(LogInViewModel login)
        {
            string sql = "select * from Company";
            List<CompanyModel> companies = SqlDataAccess.LoadData<CompanyModel>(sql);

            foreach (CompanyModel data in companies)
            {
                if (data.CompanyEmail == login.Email && data.Password == login.Password)
                {
                    return data;
                }
            }

            return null;
        }
    }
}