using AutoMapper;
using CareQual_Tracker.Models.Models.CareStaff;
using CareQual_Tracker.ViewModels.ViewModels;

namespace CareQual_Tracker.ViewModels.Mapping
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            CreateMap<Staff, StaffViewModel>();
            CreateMap<StaffViewModel, Staff>();
        }
    }
}