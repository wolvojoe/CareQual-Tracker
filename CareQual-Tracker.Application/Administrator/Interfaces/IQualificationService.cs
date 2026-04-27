using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.Administrator.Interfaces
{
    public interface IQualificationService
    {
        List<QualificationViewModel> GetAllQualifications();
        QualificationViewModel GetQualificationById(int id);
        QualificationViewModel CreateQualification(QualificationViewModel model);
        void UpdateQualification(QualificationViewModel model);
        void DeleteQualification(int id);
    }
}
