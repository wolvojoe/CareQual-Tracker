using CareQual_Tracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareQual_Tracker.Application.Administrator.Interfaces
{
    public interface IQualificationService
    {

        List<Qualification> GetAllQualifications();

    }
}
