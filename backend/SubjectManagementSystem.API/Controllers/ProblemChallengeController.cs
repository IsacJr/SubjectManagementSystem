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
        public IEnumerable<ProblemChallenge> GetAll()
        {
            return _problemChallengeService.GetAll();
        }

        [HttpGet("{id}")]
        public ProblemChallenge Get(int id)
        {
            return _problemChallengeService.GetOne(id);
        }

        [HttpPost]
        public ProblemChallenge Create(ProblemChallenge problemChallenge)
        {
            return _problemChallengeService.Insert(problemChallenge);
        }

        [HttpPut]
        public ProblemChallenge Update(ProblemChallenge problemChallenge)
        {
            return _problemChallengeService.Update(problemChallenge);
        }

        [HttpDelete("{id}")]
        public ProblemChallenge Delete(int id)
        {
            return _problemChallengeService.Delete(id);
        }
    }
}