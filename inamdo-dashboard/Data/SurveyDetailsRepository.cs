using dashboard.Data;
using dashboard.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dashboard.Interfaces
{
    public class SurveyDetailsRepository : ISurveyDetailRepository
    {
        private readonly DatabaseContext _context = null;

        public SurveyDetailsRepository(Microsoft.Extensions.Options.IOptions<Settings> settings)
        {
            _context = new DatabaseContext(settings);
        }

        public async Task<IEnumerable<SurveyDetail>> GetSurveyDetail(string userId)
        {
            ObjectId newUserId = new ObjectId(userId);

            List<SurveyDetail> surveyDetails = new List<SurveyDetail>();

            List<Question> questions = await _context.Questions.Find(_ => true).ToListAsync();
            List<Response> responses = await _context.Responses.Find(r => r.userId == newUserId).ToListAsync();

            foreach (Question q in questions)
            {
                Response response = responses.Where(r1 => r1.questionId == q.questionId).FirstOrDefault();
                SurveyDetail detail = new SurveyDetail();
                detail.QuestionDesc = q.questionDesc;
                detail.QuestionType = q.questionType;
                detail.Choice = response.choice;
                surveyDetails.Add(detail);
            }
            return surveyDetails;
        }
    }
}
