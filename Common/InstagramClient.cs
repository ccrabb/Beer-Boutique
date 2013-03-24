using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeast
{
    public static class InstagramClient {
        private readonly static string _clientId = ConfigurationManager.AppSettings["InstagramClientID"];
        private readonly static string _clientSecret = ConfigurationManager.AppSettings["InstagramClientSecret"];

        public static IEnumerable<string> GetImages(string beerName) {
            return new List<string>();
        } 

    }
}
