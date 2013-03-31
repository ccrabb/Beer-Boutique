using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerBoutique.Common
{
    public static class MvcHelpers
    {
        public static string GoogleStaticImageUrl = "http://maps.googleapis.com/maps/api/staticmap?center={0}&zoom=13&size=400x250&sensor=false&markers={0}";
        public static string GoogleSearchUrl = "http://maps.google.com?q={0}";

        public static MvcHtmlString StaticMapImage(this HtmlHelper helper, string location) {
            var url = String.Format(GoogleStaticImageUrl, location);
            return new MvcHtmlString(String.Format("<a href=\"{0}\" target=\"_new\"><img src={1} /></a>", String.Format(GoogleSearchUrl, location), url));
        }
    }
}