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
    
    public partial class BreweryEvent
    {
        public int ID { get; set; }
        public int BreweryID { get; set; }
        public string EventName { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> AddressID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public byte[] Modified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Brewery Brewery { get; set; }
    }
}