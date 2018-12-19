using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dashboard.Interfaces;
using dashboard.Model;

namespace inamdo_dashboard.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class UserDetailsController : Controller
    {
        public IUserDetailRepository _userDetailRepository;

        public UserDetailsController(IUserDetailRepository userDetailRepository)
        {
            _userDetailRepository = userDetailRepository;
        }

        public async Task<IEnumerable<UserDetail>> GetUserDetails()
        {
            return await _userDetailRepository.GetUserDetail();
        }
    }
}