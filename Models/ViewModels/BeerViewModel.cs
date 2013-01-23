using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    [DataContract]
    public class BeerViewModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Brewery { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Style { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public float? ABV { get; set; }
        [DataMember]
        public int? IBU { get; set; }
        [DataMember]
        public int? SRM { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int BreweryID { get; set; }
        [DataMember]
        public double? AverageOverall { get; set; }

        [DataMember]
        public List<BeerViewModel> SimilarBeers { get; set; }

        [DataMember]
        public string FullStyle { get; set; }

        public BeerViewModel(Beer beer) {
            ID = beer.ID;
            BreweryID = beer.BreweryID;
            Brewery = beer.Brewery.Name;
            Location = String.Join(" / ", beer.Brewery.Contact.Address.Locality, beer.Brewery.Contact.Address.Region);
            Category = beer.Style.Category.Name;
            Style = beer.Style.Name;
            Name = beer.Name;
            ABV = beer.ABV;
            IBU = beer.IBU;
            SRM = beer.SRM;
            Description = beer.Description;
            FullStyle = String.Join(" / ", Category, Style);
            if(beer.Ratings != null)
                AverageOverall = beer.Ratings.Average(x => x.Overall);
        }
    }
}
