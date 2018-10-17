using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dashboard.Interfaces;
using dashboard.Model;

namespace inamdo_dashboard.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class ResponsesController : Controller
    {
        public IResponseRepository _surveyResponseRepository;
        
        public ResponsesController(IResponseRepository surveyResponseRepository)
        {
            _surveyResponseRepository = surveyResponseRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Response>> Get()
        {
            return await _surveyResponseRepository.GetResponses();
        }
    }
}