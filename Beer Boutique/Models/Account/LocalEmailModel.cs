using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBoutique.Models.Account
{
    public class LocalEmailModel
    {
        [Required]
        [RegularExpression(@"+\@.+\..+")]
        public string OldEmail { get; set; }
        [Required]
        [RegularExpression(@"+\@.+\..+")]
        public string NewEmail { get; set; }
        [Required]
        [RegularExpression(@"+\@.+\..+")]
        public string ConfirmEmail { get; set; }
    }
}