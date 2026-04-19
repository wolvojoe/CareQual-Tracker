using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.Authentication.Interfaces
{
    public interface ICareQualUserAuthService
    {

        bool Login(string emailAddress, string password);

        CareQualUserViewModel Register(string emailAddress, string password);

    }
}
