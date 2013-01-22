using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBoutique.Models.Account
{
    public class RegisterExternalLoginModel
    {
        public string UserName { get; set; }
        public string ExternalLoginData { get; set; }
    }
}