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
    public class FieldController : ControllerBase
    {
        private readonly ILogger<FieldController> _logger;
        private readonly IFieldService _fieldService;

        public FieldController(ILogger<FieldController> logger, IFieldService fieldService)
        {
            _logger = logger;
            _fieldService = fieldService;
        }

        [HttpGet]
        public IEnumerable<Field> GetAll()
        {
            return _fieldService.GetAll();
        }

        [HttpGet("{id}")]
        public Field Get(int id)
        {
            return _fieldService.GetOne(id);
        }

        [HttpPost]
        public Field Create(Field field)
        {
            return _fieldService.Insert(field);
        }

        [HttpPut]
        public Field Update(Field field)
        {
            return _fieldService.Update(field);
        }

        [HttpDelete("{id}")]
        public Field Delete(int id)
        {
            return _fieldService.Delete(id);
        }
    }
}