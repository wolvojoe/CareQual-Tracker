using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Models.Models.CareStaff
{
    public class StaffQualification
    {
        public int StaffQualificationId { get; set; }



        public string Grade { get; set; }

        public string CertificateDocument { get; set; }


        public DateTime AttainmentDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;



        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }

        public int QualificationId { get; set; }
        public virtual Qualification Qualification { get; set; }

    }
}
