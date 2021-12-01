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
        public async Task<IEnumerable<Subject>> GetAll()
        {
            return await _subjectService.getAll();
        }

        [HttpGet("{id}")]
        public async Task<Subject> Get(int id)
        {
            return await _subjectService.getOne(id);
        }

        [HttpPost]
        public async Task<Subject> Create(Subject subject)
        {
            return await _subjectService.Insert(subject);
        }

        [HttpPut]
        public async Task<Subject> Update(Subject subject)
        {
            return await _subjectService.Update(subject);
        }

        [HttpDelete("{id}")]
        public async Task<Subject> Delete(int id)
        {
            return await _subjectService.Delete(id);
        }
    }
}