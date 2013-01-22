using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBoutique.Models.Account
{
    public class RegisterModel
    {
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [DisplayName("Confirm Password")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "The Password and Confirm Password fields did not match.")]
        public string ConfirmPassword { get; set; }
        //[RegularExpression(@"+\@.+\..+")]
        //public string Email { get; set; }
    }
}