using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Data.Repositories.Interfaces
{
    public interface IQualificationRepository
    {

        List<Qualification> GetAllQualifications();
    }
}
