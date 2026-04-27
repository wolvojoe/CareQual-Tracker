using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories
{
    public class QualificationRepository : IQualificationRepository
    {
        private readonly CareQualTrackerDbContext _context;

        public QualificationRepository(CareQualTrackerDbContext context)
        {
            _context = context;
        }

        public List<Qualification> GetAllQualifications()
        {
            return _context.Qualification.Where(x => x.IsDeleted == false).ToList();
        }

        public Qualification GetById(int id)
        {
            return _context.Qualification.SingleOrDefault(q => q.QualificationId == id);
        }

        public Qualification Add(Qualification qualification)
        {
            var added = _context.Qualification.Add(qualification);
            _context.SaveChanges();
            return added;
        }

        public void Update(Qualification qualification)
        {
            var existing = _context.Qualification.SingleOrDefault(q => q.QualificationId == qualification.QualificationId);
            if (existing == null) throw new ArgumentException("Qualification not found", nameof(qualification));
            existing.Name = qualification.Name;
            existing.AwardingBody = qualification.AwardingBody;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Qualification.FirstOrDefault(x => x.QualificationId == id).IsDeleted = true;
            _context.SaveChanges();
        }
    }
}
