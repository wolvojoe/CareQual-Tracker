using CareQual_Tracker_Models.Models;
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

        CareQualUser Register(string emailAddress, string password);

    }
}
