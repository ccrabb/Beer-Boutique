using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.ViewModels;

namespace Facades.ReviewFacade
{
    public interface IReviewFacade {
        ReviewViewModel GetReview(int beerId, int userId);
        bool Review(Review review);
        IEnumerable<ReviewViewModel> GetByBeer(int beerId);
    }
}
