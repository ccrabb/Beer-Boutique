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
    
    public partial class BreweryGeocode
    {
        public int ID { get; set; }
        public int BreweryID { get; set; }
        public System.Data.Spatial.DbGeometry Location { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string Accuracy { get; set; }
        public System.DateTime Timestamp { get; set; }
        public Nullable<int> OldID { get; set; }
        public Nullable<int> OldBreweryID { get; set; }
    
        public virtual Brewery Brewery { get; set; }
    }
}
