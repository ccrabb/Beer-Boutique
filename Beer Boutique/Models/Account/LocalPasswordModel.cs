using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerBoutique.Models.Account
{
    public class LocalPasswordModel
    {
        [DisplayName("Old Password")]
        public string OldPassword { get; set; }
        [DisplayName("New Password")]
        public string NewPassword { get; set; }
        [DisplayName("Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "The New Password and Confirm Password fields did not match.")]
        public string ConfirmPassword { get; set; }
    }
}