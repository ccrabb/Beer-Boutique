using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBoutique
{
    public static class Constants {
        public const string FACEBOOK_IMAGE_URI = "http://graph.facebook.com/{0}/picture";
        public const string TWITTER_IMAGE_URI = "https://api.twitter.com/1/users/profile_image?user_id={0}";
        public const string GOOGLE_IMAGE_URI = "https://www.google.com/s2/photos/profile/{0}";
    }

    public static class Alerts {
        public static string ALERT_ERROR = "<strong>Party Foul!</strong> Sorry we messed up, the next beer is on us.";
        public static string ALERT_UNAUTHORIZED = "<strong>Party Foul!</strong> You must be logged in to perform that action";
        public static string SUCCESS_RATING = "<strong>Cheers!</strong> Thanks for rating this beer";
        public static string SUCCESS_REVIEW = "<strong>Cheers!</strong> Thanks for reviewing this beer!";
    }
}