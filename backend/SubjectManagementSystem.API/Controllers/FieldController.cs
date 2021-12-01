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
        public async Task<IEnumerable<Field>> GetAll()
        {
            return await _fieldService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Field> Get(int id)
        {
            return await _fieldService.GetOne(id);
        }

        [HttpPost]
        public async Task<Field> Create(Field field)
        {
            return await _fieldService.Insert(field);
        }

        [HttpPut]
        public async Task<Field> Update(Field field)
        {
            return await _fieldService.Update(field);
        }

        [HttpDelete("{id}")]
        public async Task<Field> Delete(int id)
        {
            return await _fieldService.Delete(id);
        }
    }
}