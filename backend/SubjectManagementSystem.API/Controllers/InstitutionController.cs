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
        public IEnumerable<Institution> GetAll()
        {
            return _institutionService.getAll();
        }

        [HttpGet("{id}")]
        public Institution Get(int id)
        {
            return _institutionService.getOne(id);
        }

        [HttpPost]
        public Institution Create(Institution institution)
        {
            return _institutionService.Insert(institution);
        }

        [HttpPut]
        public Institution Update(Institution institution)
        {
            return _institutionService.Update(institution);
        }

        [HttpDelete("{id}")]
        public Institution Delete(int id)
        {
            return _institutionService.Delete(id);
        }
    }
}