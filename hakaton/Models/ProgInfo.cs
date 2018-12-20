using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace hakaton.Models
{
    public class ProgInfo
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Info")]
        public Info Info { get; set; }

        public ProgInfo()
        {
            Info = getInfo();
        }

        static Info getInfo()
        {
            StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ProgInformation.txt"));
            string[] first = reader.ReadLine().Split(';');
            Info st = new Info()
            {
                Cent = int.Parse(first[0]),
                //Cent = ParserError..ToInt32(first[0]),
                CurrentParticipant = int.Parse(first[1]),
                ParticipantNum = int.Parse(first[2]),
                PStatic = int.Parse(first[3]),
                VotersNum = int.Parse(first[4])
            };
            reader.Close();
            return st;
        }
    }
}