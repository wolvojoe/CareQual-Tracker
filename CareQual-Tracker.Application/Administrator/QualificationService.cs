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

        public List<QualificationViewModel> GetAllQualifications()
        {
            var qualifications = _qualificationRepository.GetAllQualifications();
            return _mapper.Map<List<QualificationViewModel>>(qualifications);
        }

        public QualificationViewModel GetQualificationById(int id)
        {
            var entity = _qualificationRepository.GetById(id);
            return entity == null ? null : _mapper.Map<QualificationViewModel>(entity);
        }

        public QualificationViewModel CreateQualification(QualificationViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<Qualification>(model);
            var created = _qualificationRepository.Add(entity);
            return _mapper.Map<QualificationViewModel>(created);
        }

        public void UpdateQualification(QualificationViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<Qualification>(model);
            _qualificationRepository.Update(entity);
        }

        public void DeleteQualification(int id)
        {
            _qualificationRepository.Delete(id);
        }
    }
}
