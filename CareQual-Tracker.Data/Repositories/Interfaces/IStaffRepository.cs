using CareQual_Tracker_Models.Models.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories.Interfaces
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetByCareHome(int careHomeId);
        Staff GetById(int id);
        void Add(Staff Staff);
        void Update(Staff Staff);
        void Delete(int id);
        void Save();
    }
}
