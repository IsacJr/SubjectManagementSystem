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
        public IEnumerable<Classroom> GetAll()
        {
            return _classroomService.getAll();
        }

        [HttpGet("{id}")]
        public Classroom Get(int id)
        {
            return _classroomService.getOne(id);
        }

        [HttpPost]
        public Classroom Create(Classroom classroom)
        {
            return _classroomService.Insert(classroom);
        }

        [HttpPut]
        public Classroom Update(Classroom classroom)
        {
            return _classroomService.Update(classroom);
        }

        [HttpDelete("{id}")]
        public Classroom Delete(int id)
        {
            return _classroomService.Delete(id);
        }
    }
}