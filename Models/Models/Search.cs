using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public enum SearchType {
        [Description("Beer")]
        Beer = 1,
        [Description("Brewery")]
        Brewery = 2
    }

    [DataContract]
    public class Search
    {
        [DataMember]
        public SearchType SearchType { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
