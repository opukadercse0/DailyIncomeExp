using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyIncomeExp.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompaniEmail { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }

    }
}