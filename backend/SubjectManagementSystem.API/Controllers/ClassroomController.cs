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
    public class ClassroomController : ControllerBase
    {
        private readonly ILogger<ClassroomController> _logger;
        private readonly IClassroomService _classroomService;

        public ClassroomController(ILogger<ClassroomController> logger, IClassroomService classroomService)
        {
            _logger = logger;
            _classroomService = classroomService;
        }

        [HttpGet]
        public async Task<IEnumerable<Classroom>> GetAll([FromQuery]FilterValue filter)
        {
            return await _classroomService.getAll(filter);
        }

        [HttpGet("{id}")]
        public async Task<Classroom> Get(int id)
        {
            return await _classroomService.getOne(id);
        }

        [HttpPost]
        public async Task<Classroom> Create(Classroom classroom)
        {
            return await _classroomService.Insert(classroom);
        }

        [HttpPut]
        public async Task<Classroom> Update(Classroom classroom)
        {
            return await _classroomService.Update(classroom);
        }

        [HttpDelete("{id}")]
        public async Task<Classroom> Delete(int id)
        {
            return await _classroomService.Delete(id);
        }
    }
}