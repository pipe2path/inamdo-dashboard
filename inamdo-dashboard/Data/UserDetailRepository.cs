using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dashboard.Interfaces;
using dashboard.Model;
using MongoDB.Driver;

namespace dashboard.Data
{
    public class UserDetailRepository : IUserDetailRepository
    {
        private readonly DatabaseContext _context = null;

        public UserDetailRepository(Microsoft.Extensions.Options.IOptions<Settings> settings)
        {
            _context = new DatabaseContext(settings);
        }

        public async Task<IEnumerable<UserDetail>> GetUserDetail()
        {
            try
            {
                UserDetail userDetail = new UserDetail();
                List<UserDetail> userDetails = new List<UserDetail>();
                List<User> users = await _context.Users.Find(_ => true).ToListAsync();
                List<Question> questions = await _context.Questions.Find(_ => true).ToListAsync();

                foreach (User u in users)
                {
                    userDetail.internalId = u.internalId;
                    userDetail.surveyId = u.surveyId;
                    userDetail.userName = u.userName;
                    userDetail.userPhone = u.userPhone;
                    userDetail.userEmail = u.userEmail;
                    userDetail.optIn = u.optIn;
                    List<Response> responses = await _context.Responses.Find(r => r.userId == u.internalId).ToListAsync();
                    List<UserDetailResponse> udResponses = new List<UserDetailResponse>();
                    foreach (Question q in questions)
                    {
                        Response response = await _context.Responses.Find(s => s.questionId == q.questionId).SingleOrDefaultAsync();
                        UserDetailResponse udResponse = new UserDetailResponse();
                        udResponse.questionDesc = q.questionDesc;
                        udResponse.questionType = q.questionType;
                        udResponse.choice = response.choice;
                        udResponses.Add(udResponse);
                    }
                    userDetail.responses = udResponses;
                    userDetails.Add(userDetail);
                }
                return userDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
