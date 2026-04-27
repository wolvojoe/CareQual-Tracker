using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Models.Models
{
    public class Qualification
    {
        public int QualificationId { get; set; }

        public string Name { get; set; }

        public string AwardingBody { get; set; }

        public bool IsDeleted { get; set; }
    }
}
