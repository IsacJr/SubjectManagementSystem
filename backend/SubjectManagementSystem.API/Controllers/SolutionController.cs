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
    public class SolutionController : ControllerBase
    {
        private readonly ILogger<SolutionController> _logger;
        private readonly ISolutionService _solutionService;

        public SolutionController(ILogger<SolutionController> logger, ISolutionService solutionService)
        {
            _logger = logger;
            _solutionService = solutionService;
        }

        [HttpGet]
        public async Task<IEnumerable<Solution>> GetAll()
        {
            return await _solutionService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Solution> Get(int id)
        {
            return await _solutionService.GetOne(id);
        }

        [HttpPost]
        public async Task<Solution> Create(Solution solution)
        {
            return await _solutionService.Insert(solution);
        }

        [HttpPut]
        public async Task<Solution> Update(Solution solution)
        {
            return await _solutionService.Update(solution);
        }

        [HttpDelete("{id}")]
        public async Task<Solution> Delete(int id)
        {
            return await _solutionService.Delete(id);
        }
    }
}