using CareQual_Tracker.Application.Authentication.Interfaces;
using CareQual_Tracker.Data.Repositories;
using CareQual_Tracker.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.Authentication
{
    public class CareQualUserAuthService : ICareQualUserAuthService
    {
        private readonly ICareQualUserRepository _careQualUserRepository;

        public CareQualUserAuthService(ICareQualUserRepository careQualUserRepository)
        {
            _careQualUserRepository = careQualUserRepository;
        }


        public bool Login(string emailAddress, string password)
        {
            var user = _careQualUserRepository.GetByEmailAddress(emailAddress);

            if (user == null)
                return false;

            bool valid = PasswordHelper.VerifyPassword(
                password,
                user.PasswordHash,
                user.PasswordSalt
            );

            if (!valid)
            {
                return false;
            }

            return true;
        }

    }
}
