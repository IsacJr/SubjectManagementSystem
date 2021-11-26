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
        public IEnumerable<Team> GetAll()
        {
            return _teamService.getAll();
        }

        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _teamService.getOne(id);
        }

        [HttpPost]
        public Team Create(Team team)
        {
            return _teamService.Insert(team);
        }

        [HttpPut]
        public Team Update(Team team)
        {
            return _teamService.Update(team);
        }

        [HttpDelete("{id}")]
        public Team Delete(int id)
        {
            return _teamService.Delete(id);
        }
    }
}