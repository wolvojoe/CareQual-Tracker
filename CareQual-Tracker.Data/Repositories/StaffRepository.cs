using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker_Models.Models.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly CareQualTrackerDbContext _context;

        public StaffRepository(CareQualTrackerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Staff> GetByCareHome(int careHomeId)
        {
            return _context.Staff
                .Where(s => s.CareHomeId == careHomeId)
                .ToList();
        }

        public Staff GetById(int id)
        {
            return _context.Staff.Find(id);
        }

        public void Add(Staff Staff)
        {
            _context.Staff.Add(Staff);
        }

        public void Update(Staff Staff)
        {
            _context.Entry(Staff).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var Staff = _context.Staff.Find(id);
            if (Staff != null)
                _context.Staff.Remove(Staff);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
