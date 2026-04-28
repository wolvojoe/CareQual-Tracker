using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Models.Models.CareStaff
{
    public class StaffSalary
    {
        public int StaffSalaryId { get; set; }

        public decimal SalaryAmount { get; set; }


        // TODO: Payroll information, Currency, Taxcode, Umbrella company etc


        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; }

        public int SalaryFrequencyId { get; set; }

        public virtual SalaryFrequency SalaryFrequency { get; set; }

    }
}
