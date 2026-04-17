using CareQual_Tracker_Models.Models.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data
{
    public class CareQualTrackerDbContext : DbContext
    {
        public CareQualTrackerDbContext() : base("name=CareQualTrackerDb")
        {
        }


        //public DbSet<CareHome> CareHomes { get; set; }
        public DbSet<Staff> Staff { get; set; }
        //public DbSet<Qualification> Qualifications { get; set; }
    }
}
