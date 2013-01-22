using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBoutique.Models.Account
{
    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}