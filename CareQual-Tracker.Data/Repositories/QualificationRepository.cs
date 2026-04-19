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
            return _context.Qualification.ToList();
        }

    }
}
