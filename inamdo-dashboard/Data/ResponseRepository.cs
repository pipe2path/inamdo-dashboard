using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dashboard.Interfaces;
using dashboard.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace dashboard.Data
{
    public class ResponseRepository : IResponseRepository
    {
        private readonly DatabaseContext _context = null;

        public ResponseRepository(IOptions<Settings> settings)
        {
            _context = new DatabaseContext(settings);
        }

        public async Task<IEnumerable<Response>> GetResponses()
        {
            try
            {
                return await _context.Responses.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
