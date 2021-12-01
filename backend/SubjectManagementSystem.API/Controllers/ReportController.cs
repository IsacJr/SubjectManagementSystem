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
        public IEnumerable<Report> GetAll()
        {
            return _reportService.GetAll();
        }

        [HttpGet("{id}")]
        public Report Get(int id)
        {
            return _reportService.GetOne(id);
        }

        [HttpPost]
        public Report Create(Report report)
        {
            return _reportService.Insert(report);
        }

        [HttpPut]
        public Report Update(Report report)
        {
            return _reportService.Update(report);
        }

        [HttpDelete("{id}")]
        public Report Delete(int id)
        {
            return _reportService.Delete(id);
        }
    }
}