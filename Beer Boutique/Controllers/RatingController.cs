using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Facades.RatingFacade;

namespace BeerBoutique.Controllers
{
    public class RatingController : Controller
    {
        //
        // GET: /Rating/

        [HttpPost]
        public ActionResult Rate(int beerId, double score) {
            if (User.Identity.IsAuthenticated) {
                var userID = Convert.ToInt32((Membership.GetUser(User.Identity.Name)).ProviderUserKey);
                var ratings = new RatingFacade();
                var success = ratings.Rate(beerId, score*2, userID);

                return Json(success);
            }

            return new HttpNotFoundResult();
        }
    }
}
