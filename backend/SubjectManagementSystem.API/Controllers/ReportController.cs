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
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IReportService _reportService;

        public ReportController(ILogger<ReportController> logger, IReportService reportService)
        {
            _logger = logger;
            _reportService = reportService;
        }

        [HttpGet]
        public async Task<IEnumerable<Report>> GetAll()
        {
            return await _reportService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Report> Get(int id)
        {
            return await _reportService.GetOne(id);
        }

        [HttpPost]
        public async Task<Report> Create(Report report)
        {
            return await _reportService.Insert(report);
        }

        [HttpPut]
        public async Task<Report> Update(Report report)
        {
            return await _reportService.Update(report);
        }

        [HttpDelete("{id}")]
        public async Task<Report> Delete(int id)
        {
            return await _reportService.Delete(id);
        }
    }
}