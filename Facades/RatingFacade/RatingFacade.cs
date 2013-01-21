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
        public bool Rate(int beerId, double score)
        {
            var context = new BeerBoutiqueEntities();
            context.Ratings.Add(new Rating()
            {
                BeerID = beerId,
                Overall = score,
                UserID = 0
            });

            context.SaveChanges();
            return true;
        }
    }
}
