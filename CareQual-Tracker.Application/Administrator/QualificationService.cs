using AutoMapper;
using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models;
using CareQual_Tracker.ViewModels.ViewModels;
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
        private readonly IMapper _mapper;

        public QualificationService(IQualificationRepository qualificationRepository, IMapper mapper)
        {
            _qualificationRepository = qualificationRepository;
            _mapper = mapper;
        }


        public List<CareQualUserViewModel> GetAllQualifications()
        {
            var qualifications = _qualificationRepository.GetAllQualifications();
            return _mapper.Map<List<CareQualUserViewModel>>(qualifications);
        }

    }
}
