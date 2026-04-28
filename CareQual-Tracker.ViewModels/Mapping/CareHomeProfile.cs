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
    public class CareHomeProfile : Profile
    {

        public CareHomeProfile()
        {
            CreateMap<CareHome, CareHomeViewModel>();
            CreateMap<CareHomeViewModel, CareHome>();
        }
    }
}
