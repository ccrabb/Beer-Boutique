using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Models;

namespace BeerBoutique.Models.Reviews
{
    [DataContract]
    public class ReviewsModel
    {
        [DataMember]
        public int BeerId { get; set; }
        [DataMember]
        public IEnumerable<Review> Reviews { get; set; } 
    }
}