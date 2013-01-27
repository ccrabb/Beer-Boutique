using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facades.ReviewFacade;
using Models;
using WebMatrix.WebData;

namespace BeerBoutique.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public ActionResult _Review(int beerId)
        {
            var reviewFacade = new ReviewFacade();
            var rating = reviewFacade.GetReview(beerId, WebSecurity.CurrentUserId);

            if (rating != null)
            {
                return View(rating.Review);
            }

            return View(new Review() { BeerID = beerId });
        }

        [HttpPost]
        public ActionResult _Review(Review review)
        {
            var reviewFacade = new ReviewFacade();

            review.UserID = WebSecurity.CurrentUserId;
            reviewFacade.Review(review);

            return View();
        }

        [HttpGet]
        public ActionResult _Reviews(int beerId) {
            var reviewFacade = new ReviewFacade();

            var reviews = reviewFacade.GetByBeer(beerId);

            return View(reviews);

        }
    }
}
