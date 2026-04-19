using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.Administrator
{
    public class QualificationService : IQualificationService
    {
        private readonly IQualificationRepository _qualificationRepository;

        public QualificationService(IQualificationRepository qualificationRepository)
        {
            _qualificationRepository = qualificationRepository;
        }


        public List<Qualification> GetAllQualifications()
        {
            return _qualificationRepository.GetAllQualifications();
        }

    }
}
