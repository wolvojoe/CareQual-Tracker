using CareQual_Tracker_Models.Models;
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


        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffQualification> StaffQualification { get; set; }
        public DbSet<StaffSalary> StaffSalary { get; set; }


        public DbSet<CareHome> CareHome { get; set; }

        public DbSet<CareQualUser> CareQualUser { get; set; }


        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SalaryFrequency> SalaryFrequency { get; set; }



    }
}
