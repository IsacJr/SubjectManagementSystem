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
    public class StageController : ControllerBase
    {
        private readonly ILogger<StageController> _logger;
        private readonly IStageService _stageService;

        public StageController(ILogger<StageController> logger, IStageService stageService)
        {
            _logger = logger;
            _stageService = stageService;
        }

        [HttpGet]
        public async Task<IEnumerable<Stage>> GetAll()
        {
            return await _stageService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Stage> Get(int id)
        {
            return await _stageService.GetOne(id);
        }

        [HttpPost]
        public async Task<Stage> Create(Stage stage)
        {
            return await _stageService.Insert(stage);
        }

        [HttpPut]
        public async Task<Stage> Update(Stage stage)
        {
            return await _stageService.Update(stage);
        }

        [HttpDelete("{id}")]
        public async Task<Stage> Delete(int id)
        {
            return await _stageService.Delete(id);
        }
    }
}