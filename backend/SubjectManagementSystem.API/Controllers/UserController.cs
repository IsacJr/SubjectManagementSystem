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
        public IEnumerable<User> GetAll()
        {
            return _userService.getAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.getOne(id);
        }

        [HttpPost]
        public User Create(User user)
        {
            return _userService.Insert(user);
        }

        [HttpPut]
        public User Update(User user)
        {
            return _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            return _userService.Delete(id);
        }
    }
}