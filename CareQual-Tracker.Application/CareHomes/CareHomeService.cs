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
using CareQual_Tracker.Application.CareHomes.Interfaces;

namespace CareQual_Tracker.Application.CareHomes
{
    public class CareHomeService : ICareHomeService
    {
        private readonly ICareHomeRepository _careHomeRepository;
        private readonly IMapper _mapper;

        public CareHomeService(ICareHomeRepository careHomeRepository, IMapper mapper)
        {
            _careHomeRepository = careHomeRepository;
            _mapper = mapper;
        }

        public List<CareHomeViewModel> GetAllCareHomes()
        {
            var careHomes = _careHomeRepository.GetAllCareHomes();
            return _mapper.Map<List<CareHomeViewModel>>(careHomes);
        }

        public CareHomeViewModel GetCareHomeById(int id)
        {
            var entity = _careHomeRepository.GetById(id);
            return entity == null ? null : _mapper.Map<CareHomeViewModel>(entity);
        }

        public CareHomeViewModel CreateCareHome(CareHomeViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<CareHome>(model);
            var created = _careHomeRepository.Add(entity);
            return _mapper.Map<CareHomeViewModel>(created);
        }

        public void UpdateCareHome(CareHomeViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<CareHome>(model);
            _careHomeRepository.Update(entity);
        }

        public void DeleteCareHome(int id)
        {
            _careHomeRepository.Delete(id);
        }
    }
}