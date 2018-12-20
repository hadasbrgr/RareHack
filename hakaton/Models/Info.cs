using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hakaton.Models
{
    public class Info
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public string birthDate { get; set; }

    }
}