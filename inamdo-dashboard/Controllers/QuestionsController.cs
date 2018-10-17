using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dashboard.Interfaces;
using dashboard.Model;

namespace dashboard.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        public IQuestionRepository _questionsRepository;

        public QuestionsController(IQuestionRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        //[NoCache]
        [HttpGet]
        public async Task<IEnumerable<Question>> Get()
        {
            return await _questionsRepository.GetQuestions();
        }

        [HttpGet("{id}")]
        public async Task<Question> Get(int id)
        {
            return await _questionsRepository.GetQuestionById(id);
        }
        
    }
}