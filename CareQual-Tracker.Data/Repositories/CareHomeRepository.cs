using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories
{
    public class CareHomeRepository : ICareHomeRepository
    {
        private readonly CareQualTrackerDbContext _context;

        public CareHomeRepository(CareQualTrackerDbContext context)
        {
            _context = context;
        }

        public List<CareHome> GetAllCareHomes()
        {
            return _context.CareHome.ToList();
        }

        public CareHome GetById(int id)
        {
            return _context.CareHome.SingleOrDefault(ch => ch.CareHomeId == id);
        }

        public CareHome Add(CareHome careHome)
        {
            var added = _context.CareHome.Add(careHome);
            _context.SaveChanges();
            return added;
        }

        public void Update(CareHome careHome)
        {
            var existing = _context.CareHome.SingleOrDefault(ch => ch.CareHomeId == careHome.CareHomeId);
            if (existing == null) throw new ArgumentException("CareHome not found", nameof(careHome));

            // Copy updated values from the incoming entity to the tracked entity.
            // Using Entry.CurrentValues.SetValues keeps EF change tracking correct.
            _context.Entry(existing).CurrentValues.SetValues(careHome);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var existing = _context.CareHome.SingleOrDefault(ch => ch.CareHomeId == id);
            if (existing == null) throw new ArgumentException("CareHome not found", nameof(id));
            _context.CareHome.Remove(existing);
            _context.SaveChanges();
        }
    }
}
