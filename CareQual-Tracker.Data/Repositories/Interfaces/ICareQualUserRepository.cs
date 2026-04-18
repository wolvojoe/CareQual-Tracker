using CareQual_Tracker_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories.Interfaces
{
    public interface ICareQualUserRepository
    {
        CareQualUser GetByEmailAddress(string emailAddress);

        CareQualUser Create(string emailAddress, string passwordHash, string passwordSalt);

    }
}
