using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dashboard.Interfaces;
using dashboard.Model;
using Microsoft.AspNetCore.Mvc;

namespace inamdo_dashboard.Controllers
{
    [Produces("application/json")]
    public class UsersController : Controller
    {
        public IUserRepository _userRepository;
        
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("api/users")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.GetUsers();
        }
    }
}