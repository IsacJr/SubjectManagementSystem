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
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private readonly ISubjectService _subjectService;

        public SubjectController(ILogger<SubjectController> logger, ISubjectService subjectService)
        {
            _logger = logger;
            _subjectService = subjectService;
        }

        [HttpGet]
        public IEnumerable<Subject> GetAll()
        {
            return _subjectService.getAll();
        }

        [HttpGet("{id}")]
        public Subject Get(int id)
        {
            return _subjectService.getOne(id);
        }

        [HttpPost]
        public Subject Create(Subject subject)
        {
            return _subjectService.Insert(subject);
        }

        [HttpPut]
        public Subject Update(Subject subject)
        {
            return _subjectService.Update(subject);
        }

        [HttpDelete("{id}")]
        public Subject Delete(int id)
        {
            return _subjectService.Delete(id);
        }
    }
}