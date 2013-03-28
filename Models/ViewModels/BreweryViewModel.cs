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
        [DataMember]
        public string TagName {
            get { return this.Name.Replace(" ", String.Empty).Replace(".", String.Empty); }
        }

        public override string ToString() {
            return Name;
        }

        public BreweryViewModel(){}
        
        public BreweryViewModel(Brewery b) {
            ID = b.ID;
            Name = b.Name;
            Description = b.Description ?? String.Empty;
            Address1 = b.Contact.Address.Address1 ?? String.Empty;
            Address2 = b.Contact.Address.Address2 ?? String.Empty;
            Address3 = b.Contact.Address.Address3 ?? String.Empty;
            Locality = b.Contact.Address.Locality ?? String.Empty;
            Region = b.Contact.Address.Region ?? String.Empty;
            PostalCode = b.Contact.Address.PostalCode ?? String.Empty;
            Country = b.Contact.Address.Country ?? String.Empty;
            Uri = b.Contact.Website ?? String.Empty;
            Phone = b.Contact.Phone ?? String.Empty;
        }
    }
}
