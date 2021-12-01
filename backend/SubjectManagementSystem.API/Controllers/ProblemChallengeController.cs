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
    public class ProblemChallengeController : ControllerBase
    {
        private readonly ILogger<ProblemChallengeController> _logger;
        private readonly IProblemChallengeService _problemChallengeService;

        public ProblemChallengeController(ILogger<ProblemChallengeController> logger, IProblemChallengeService problemChallengeService)
        {
            _logger = logger;
            _problemChallengeService = problemChallengeService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProblemChallenge>> GetAll()
        {
            return await _problemChallengeService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ProblemChallenge> Get(int id)
        {
            return await _problemChallengeService.GetOne(id);
        }

        [HttpPost]
        public async Task<ProblemChallenge> Create(ProblemChallenge problemChallenge)
        {
            return await _problemChallengeService.Insert(problemChallenge);
        }

        [HttpPut]
        public async Task<ProblemChallenge> Update(ProblemChallenge problemChallenge)
        {
            return await _problemChallengeService.Update(problemChallenge);
        }

        [HttpDelete("{id}")]
        public async Task<ProblemChallenge> Delete(int id)
        {
            return  await _problemChallengeService.Delete(id);
        }
    }
}