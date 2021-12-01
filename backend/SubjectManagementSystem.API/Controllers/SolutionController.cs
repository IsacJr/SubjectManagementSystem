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
        public IEnumerable<Solution> GetAll()
        {
            return _solutionService.GetAll();
        }

        [HttpGet("{id}")]
        public Solution Get(int id)
        {
            return _solutionService.GetOne(id);
        }

        [HttpPost]
        public Solution Create(Solution solution)
        {
            return _solutionService.Insert(solution);
        }

        [HttpPut]
        public Solution Update(Solution solution)
        {
            return _solutionService.Update(solution);
        }

        [HttpDelete("{id}")]
        public Solution Delete(int id)
        {
            return _solutionService.Delete(id);
        }
    }
}