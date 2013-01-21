using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    [DataContract]
    public class BreweryViewModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Address1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string Address3 { get; set; }
        [DataMember]
        public string Locality { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Uri { get; set; }
        [DataMember]
        public string Phone { get; set; }

        public override string ToString() {
            return Name;
        }
        
        public BreweryViewModel(Brewery b) {
            ID = b.ID;
            Name = b.Name;
            Description = b.Description;
            Address1 = b.Contact.Address.Address1;
            Address2 = b.Contact.Address.Address2;
            Address3 = b.Contact.Address.Address3;
            Locality = b.Contact.Address.Locality;
            Region = b.Contact.Address.Region;
            PostalCode = b.Contact.Address.PostalCode;
            Country = b.Contact.Address.Country;
            Uri = b.Contact.Website;
            Phone = b.Contact.Phone;
        }
    }
}
