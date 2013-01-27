using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    [DataContract]
    public class ReviewViewModel
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public Review Review { get; set; }
        [DataMember]
        public double WeightedScore { get; set; }

        public ReviewViewModel(Review review) {
            if (review.User == null) {
                throw new ArgumentException("Review.User cannot be null");
            }

            var aggregate = 0D;
            var avg = 0;
            if (review.TasteScore.HasValue) {
                aggregate += review.TasteScore.Value*3;
                avg += 3;
            }

            if (review.AppearanceScore.HasValue) {
                aggregate += review.AppearanceScore.Value;
                avg += 1;
            }

            if (review.AromaScore.HasValue) {
                aggregate += review.AromaScore.Value*2;
                avg += 2;
            }

            if (avg > 0) {
                this.WeightedScore = aggregate/avg;
            }

            this.Review = review;
            this.UserName = review.User.UserName;
        }
    }
}
