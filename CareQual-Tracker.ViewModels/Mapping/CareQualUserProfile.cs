using AutoMapper;
using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.ViewModels.Mapping
{
    public class CareQualUserProfile : Profile
    {

        public CareQualUserProfile()
        {
            CreateMap<CareQualUser, CareQualUserViewModel>();

            CreateMap<CareQualUserViewModel, CareQualUser>();
        }
    }
}
