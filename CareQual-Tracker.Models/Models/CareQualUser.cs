using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker_Models.Models
{
    public class CareQualUser
    {
        public int CareQualUserId { get; set; }

        public string EmailAddress { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
