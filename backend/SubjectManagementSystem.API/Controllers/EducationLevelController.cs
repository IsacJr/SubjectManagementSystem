using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationLevelController : ControllerBase
    {
        private readonly ILogger<EducationLevelController> _logger;

        public EducationLevelController(ILogger<EducationLevelController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<EnumValueDto>  GetAll()
        {
            return EnumExtensions.GetValues<EducationLevelEnum>();
        }
    }
}