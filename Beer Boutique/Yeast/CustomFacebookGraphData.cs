using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BeerBoutique.Yeast
{
    [DataContract]
    public class CustomFacebookGraphData
    {
        [DataMember(Name = "birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The email.
        /// </value>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The gender.
        /// </value>
        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The id.
        /// </value>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The link.
        /// </value>
        [DataMember(Name = "link")]
        public Uri Link { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The name.
        /// </value>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The picture.
        /// </value>
        [DataMember(Name = "picture")]
        public string Picture { get; set; }
    }
}