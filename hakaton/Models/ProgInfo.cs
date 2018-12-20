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
        [Display(Name = "ListInfo")]
        public List<Info> listInfo { get; set; }

        public ProgInfo()
        {
            listInfo = getInfo();
        }

        public static List<Info> getInfo()
        {
            StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ProgInformation.txt"));
            List<Info> infoOfUsers = new List<Info>();
            string first = reader.ReadLine();
            while (first!=null)
            {
                string[] splittedInfo = first.Split(';');
                Info st = new Info()
                {
                    ID = int.Parse(splittedInfo[0]),
                    firstName = splittedInfo[1],
                    lastName = splittedInfo[2],
                    gender = splittedInfo[3],
                    birthDate = splittedInfo[4]
                    
                };
                infoOfUsers.Add(st);
                first = reader.ReadLine();
            }
            reader.Close();
            return infoOfUsers;
        }
    }
}