using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.CareHomes.Interfaces
{
    public interface ICareHomeService
    {
        List<CareHomeViewModel> GetAllCareHomes();
        CareHomeViewModel GetCareHomeById(int id);
        CareHomeViewModel CreateCareHome(CareHomeViewModel model);
        void UpdateCareHome(CareHomeViewModel model);
        void DeleteCareHome(int id);
    }
}