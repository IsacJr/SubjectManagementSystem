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
    public class InstitutionController : ControllerBase
    {
        private readonly ILogger<InstitutionController> _logger;
        private readonly IInstitutionService _institutionService;

        public InstitutionController(ILogger<InstitutionController> logger, IInstitutionService institutionService)
        {
            _logger = logger;
            _institutionService = institutionService;
        }

        [HttpGet]
        public async Task<IEnumerable<Institution>> GetAll()
        {
            return await _institutionService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Institution> Get(int id)
        {
            return await _institutionService.GetOne(id);
        }

        [HttpPost]
        public async Task<Institution> Create(Institution institution)
        {
            return await _institutionService.Insert(institution);
        }

        [HttpPut]
        public async Task<Institution> Update(Institution institution)
        {
            return await _institutionService.Update(institution);
        }

        [HttpDelete("{id}")]
        public async Task<Institution> Delete(int id)
        {
            return await _institutionService.Delete(id);
        }
    }
}