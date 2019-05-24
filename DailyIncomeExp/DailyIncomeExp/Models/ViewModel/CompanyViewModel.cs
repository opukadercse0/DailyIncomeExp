using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DailyIncomeExp.Models.ViewModel
{
    public class  CompanyViewModel
    {
        [Display(Name = "CompanyName")]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "CompaniEmail")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string CompanyEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Insert at least 6 character password")]
        public string Password { get; set; }
       
        [Display(Name = "ConfirmPassword")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match to the password")]
        public string AgainPassword { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; }
    }
}