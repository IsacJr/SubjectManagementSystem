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
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamService _teamService;

        public TeamController(ILogger<TeamController> logger, ITeamService teamService)
        {
            _logger = logger;
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _teamService.getAll();
        }

        [HttpGet("{id}")]
        public async Task<Team> Get(int id)
        {
            return await _teamService.getOne(id);
        }

        [HttpPost]
        public async Task<Team> Create(Team team)
        {
            return await _teamService.Insert(team);
        }

        [HttpPut]
        public async Task<Team> Update(Team team)
        {
            return await _teamService.Update(team);
        }

        [HttpDelete("{id}")]
        public async Task<Team> Delete(int id)
        {
            return await _teamService.Delete(id);
        }
    }
}