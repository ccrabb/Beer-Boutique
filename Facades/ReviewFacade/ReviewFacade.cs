using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.ViewModels;

namespace Facades.ReviewFacade
{
    public class ReviewFacade : IReviewFacade
    {
        public ReviewViewModel GetReview(int beerId, int userId)
        {
            if (beerId <= 0)
            {
                throw new ArgumentNullException("beerId");
            }
            if (userId <= 0)
            {
                throw new ArgumentNullException("userId");
            }

            using (var context = new BeerBoutiqueEntities())
            {
                return new ReviewViewModel(context.Reviews.FirstOrDefault(x => x.BeerID == beerId && x.UserID == userId));
            }
        }

        public bool Review(Review review)
        {

            if (review == null || review.UserID == 0 || review.BeerID == 0)
            {
                throw new ArgumentNullException("review");
            }

            using (var context = new BeerBoutiqueEntities())
            {
                var rev = context.Reviews.FirstOrDefault(x => x.BeerID == review.BeerID && x.UserID == review.UserID);

                if (rev == null)
                {
                    context.Reviews.Add(review);
                }
                else
                {
                    rev.AppearanceScore = review.AppearanceScore;
                    rev.AppearanceDescription = review.AppearanceDescription;
                    rev.AromaScore = review.AromaScore;
                    rev.AromaDescription = review.AromaDescription;
                    rev.TasteScore = review.TasteScore;
                    rev.TasteDescription = review.TasteDescription;
                    rev.OverallDescription = review.OverallDescription;
                }

                context.SaveChanges();
                return true;
            }
        }

        public IEnumerable<ReviewViewModel> GetByBeer(int beerId) {
            using (var context = new BeerBoutiqueEntities()) {
                var reviews = context.Reviews.Where(x => x.BeerID == beerId).Take(10);
                var rev = new List<ReviewViewModel>();
                foreach (var review in reviews) {
                    rev.Add(new ReviewViewModel(review));
                }

                return rev;
            }
        } 
    }
}
