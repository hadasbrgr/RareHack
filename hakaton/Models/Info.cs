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
        [Display(Name = "Cent")]
        public int Cent { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "ParticipantNum")]
        public int ParticipantNum { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "VotersNum")]
        public int VotersNum { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "CurrentParticipant")]
        public int CurrentParticipant { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "PStatic")]
        public double PStatic { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "table")]
        public string[,] Table { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "GameNumber")]
        public int GameNumber { get; set; }
    }
}