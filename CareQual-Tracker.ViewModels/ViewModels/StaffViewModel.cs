using System;

namespace CareQual_Tracker.ViewModels.ViewModels
{
    public class StaffViewModel
    {
        public int StaffId { get; set; }
        public int CareHomeId { get; set; }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal AnnualSalary { get; set; }

        public int RoleId { get; set; }

        public string FullName()
        {
            return string.Concat(Forename, " ", Surname);
        }
    }
}