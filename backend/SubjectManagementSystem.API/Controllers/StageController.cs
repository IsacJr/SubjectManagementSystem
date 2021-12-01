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
        public IEnumerable<Stage> GetAll()
        {
            return _stageService.GetAll();
        }

        [HttpGet("{id}")]
        public Stage Get(int id)
        {
            return _stageService.GetOne(id);
        }

        [HttpPost]
        public Stage Create(Stage stage)
        {
            return _stageService.Insert(stage);
        }

        [HttpPut]
        public Stage Update(Stage stage)
        {
            return _stageService.Update(stage);
        }

        [HttpDelete("{id}")]
        public Stage Delete(int id)
        {
            return _stageService.Delete(id);
        }
    }
}