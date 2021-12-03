using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Service;

namespace SubjectManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAll([FromQuery]FilterValue filter)
        {
            return await _userService.GetAll(filter);
        }

        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _userService.GetOne(id);
        }

        [HttpPost]
        public async Task<User> Create(User user)
        {
            return await _userService.Insert(user);
        }

        [HttpPut]
        public async Task<User> Update(User user)
        {
            return await _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public async Task<User> Delete(int id)
        {
            return await _userService.Delete(id);
        }

        [HttpGet("GetAllUserType")]
        public dynamic  GetAllUserType()
        {
            return EnumExtensions.GetValues<UserTypeEnum>();
        }
    }
}