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
        public async Task<IEnumerable<Challenge>> GetAll([FromQuery]FilterValue filter)
        {
            return await _challengeService.getAll(filter);
        }

        [HttpGet("{id}")]
        public async Task<Challenge> Get(int id)
        {
            return await _challengeService.getOne(id);
        }

        [HttpPost]
        public async Task<Challenge> Create(Challenge challenge)
        {
            return await _challengeService.Insert(challenge);
        }

        [HttpPut]
        public async Task<Challenge> Update(Challenge challenge)
        {
            return await _challengeService.Update(challenge);
        }

        [HttpDelete("{id}")]
        public async Task<Challenge> Delete(int id)
        {
            return await _challengeService.Delete(id);
        }
    }
}