using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dashboard.Interfaces;
using dashboard.Model;

namespace dashboard.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class SurveyDetailsController : Controller
    {
        public ISurveyDetailRepository _SurveyDetailRepository;
        public SurveyDetailsController(ISurveyDetailRepository surveyDetailRepository)
        {
            _SurveyDetailRepository = surveyDetailRepository;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<SurveyDetail>> GetSurveyDetail(string id)
        {
            return await _SurveyDetailRepository.GetSurveyDetail(id);

        }

    }
}