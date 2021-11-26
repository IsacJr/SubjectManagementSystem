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
    public class ChallengeController : ControllerBase
    {
        private readonly ILogger<ChallengeController> _logger;
        private readonly IChallengeService _challengeService;

        public ChallengeController(ILogger<ChallengeController> logger, IChallengeService challengeService)
        {
            _logger = logger;
            _challengeService = challengeService;
        }

        [HttpGet]
        public IEnumerable<Challenge> GetAll()
        {
            return _challengeService.getAll();
        }

        [HttpGet("{id}")]
        public Challenge Get(int id)
        {
            return _challengeService.getOne(id);
        }

        [HttpPost]
        public Challenge Create(Challenge challenge)
        {
            return _challengeService.Insert(challenge);
        }

        [HttpPut]
        public Challenge Update(Challenge challenge)
        {
            return _challengeService.Update(challenge);
        }

        [HttpDelete("{id}")]
        public Challenge Delete(int id)
        {
            return _challengeService.Delete(id);
        }
    }
}