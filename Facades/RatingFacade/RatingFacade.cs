using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Facades.RatingFacade
{
    public class RatingFacade : BaseFacade, IRatingFacade
    {
        public bool Rate(int beerId, double score, int userId)
        {
            using (var context = new BeerBoutiqueEntities()) {

                var currentRating = context.Ratings.FirstOrDefault(x => x.BeerID == beerId && x.UserID == userId);

                if (currentRating == null) {
                    context.Ratings.Add(new Rating()
                    {
                        BeerID = beerId,
                        Overall = score,
                        UserID = userId
                    });
                }
                else {
                    currentRating.Overall = score;
                }

                context.SaveChanges();
                return true;
            }
        }

        public Rating Get(int beerId, int userId) {
            using (var context = new BeerBoutiqueEntities()) {
                return context.Ratings.FirstOrDefault(x => x.BeerID == beerId && x.UserID == userId);
            }
        }
    }
}
