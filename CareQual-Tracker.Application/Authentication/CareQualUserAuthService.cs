using AutoMapper;
using CareQual_Tracker.Application.Authentication.Interfaces;
using CareQual_Tracker.Data.Repositories;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
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
        private readonly IMapper _mapper;


        public CareQualUserAuthService(ICareQualUserRepository careQualUserRepository, IMapper mapper)
        {
            _careQualUserRepository = careQualUserRepository;
            _mapper = mapper;

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

        public CareQualUserViewModel Register(string emailAddress, string password)
        {
            var existingUser = _careQualUserRepository.GetByEmailAddress(emailAddress);
            if (existingUser != null)
            {
                throw new Exception("A user with this email address already exists.");
            }
            PasswordHelper.CreatePasswordHash(password, out string hash, out string salt);
            var createdCareQualUser = _careQualUserRepository.Create(emailAddress, hash, salt);

            return _mapper.Map<CareQualUserViewModel>(createdCareQualUser);
        }
    }
}
