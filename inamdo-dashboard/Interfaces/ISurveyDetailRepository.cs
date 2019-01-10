using dashboard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dashboard.Interfaces
{
    public interface ISurveyDetailRepository
    {
        Task<IEnumerable<SurveyDetail>> GetSurveyDetail(string userId);
    }
}
