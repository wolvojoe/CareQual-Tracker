using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Models.Models.Staff
{
    public class Staff
    {
        public int StaffId { get; set; }
        public int CareHomeId { get; set; }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal AnnualSalary { get; set; }


        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
