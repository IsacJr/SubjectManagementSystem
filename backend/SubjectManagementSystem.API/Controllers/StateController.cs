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
    public class StateController : ControllerBase
    {
        private readonly ILogger<StateController> _logger;

        public StateController(ILogger<StateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public dynamic  GetAll()
        {
            return EnumExtensions.GetValues<StateEnum>();
        }
    }
}