using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facades.RatingFacade;

namespace BeerBoutique.Controllers
{
    public class RatingController : Controller
    {
        //
        // GET: /Rating/

        [HttpPost]
        public JsonResult Rate(int beerId, double score) {
            var ratings = new RatingFacade();
            var success = ratings.Rate(beerId, score*2);

            return Json(success);
        }
    }
}
