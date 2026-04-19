using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        public CareQualUser Create(string emailAddress, string passwordHash, string passwordSalt)
        {
            var user = new CareQualUser
            {
                EmailAddress = emailAddress,
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash
            };

            _context.CareQualUser.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
