using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories
{
    public class CareQualUserRepository : ICareQualUserRepository
    {
        private readonly CareQualTrackerDbContext _context;

        public CareQualUserRepository(CareQualTrackerDbContext context)
        {
            _context = context;
        }


        public CareQualUser GetByEmailAddress(string emailAddress)
        {
            return _context.CareQualUser.Where(x => x.EmailAddress == emailAddress).FirstOrDefault();
        }
    }
}
