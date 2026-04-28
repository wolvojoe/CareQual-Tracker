using System;
using System.Collections.Generic;
using AutoMapper;
using CareQual_Tracker.Application.CareStaff.Interfaces;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.Models.Models.CareStaff;
using CareQual_Tracker.ViewModels.ViewModels;

namespace CareQual_Tracker.Application.CareStaff
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IMapper _mapper;

        public StaffService(IStaffRepository staffRepository, IMapper mapper)
        {
            _staffRepository = staffRepository;
            _mapper = mapper;
        }

        public List<StaffViewModel> GetAllStaff()
        {
            var staff = _staffRepository.GetAllStaff();
            return _mapper.Map<List<StaffViewModel>>(staff);
        }


        public List<StaffViewModel> GetStaffByCareHome(int careHomeId)
        {
            var staff = _staffRepository.GetByCareHome(careHomeId);
            return _mapper.Map<List<StaffViewModel>>(staff);
        }

        public StaffViewModel GetStaffById(int id)
        {
            var entity = _staffRepository.GetById(id);
            return entity == null ? null : _mapper.Map<StaffViewModel>(entity);
        }

        public StaffViewModel CreateStaff(StaffViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<Staff>(model);
            _staffRepository.Add(entity);
            _staffRepository.Save();
            return _mapper.Map<StaffViewModel>(entity);
        }

        public void UpdateStaff(StaffViewModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            var entity = _mapper.Map<Staff>(model);
            _staffRepository.Update(entity);
            _staffRepository.Save();
        }

        public void DeleteStaff(int id)
        {
            _staffRepository.Delete(id);
            _staffRepository.Save();
        }
    }
}