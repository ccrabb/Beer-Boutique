//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brewery
    {
        public Brewery()
        {
            this.Beers = new HashSet<Beer>();
            this.BreweryGeocodes = new HashSet<BreweryGeocode>();
        }
    
        public int ID { get; set; }
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<int> OldID { get; set; }
    
        public virtual ICollection<Beer> Beers { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ICollection<BreweryGeocode> BreweryGeocodes { get; set; }
    }
}
