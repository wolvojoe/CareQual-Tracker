using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareQual_Tracker.Models.Models;

namespace CareQual_Tracker.Data.Repositories.Interfaces
{
    public interface ICareHomeRepository
    {
        List<CareHome> GetAllCareHomes();
        CareHome GetById(int id);
        CareHome Add(CareHome careHome);
        void Update(CareHome careHome);
        void Delete(int id);
    }
}
