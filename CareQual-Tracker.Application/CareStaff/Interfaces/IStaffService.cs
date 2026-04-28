using CareQual_Tracker.ViewModels.ViewModels;
using System.Collections.Generic;

namespace CareQual_Tracker.Application.CareStaff.Interfaces
{
    public interface IStaffService
    {
        List<StaffViewModel> GetAllStaff();
        List<StaffViewModel> GetStaffByCareHome(int careHomeId);
        StaffViewModel GetStaffById(int id);
        StaffViewModel CreateStaff(StaffViewModel model);
        void UpdateStaff(StaffViewModel model);
        void DeleteStaff(int id);
    }
}