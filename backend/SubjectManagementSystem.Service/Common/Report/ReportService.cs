using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository reportRepository;
        public ReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        public async Task<IEnumerable<Report>> GetAll(FilterValue filter)
        {
            return await reportRepository.GetAll(filter);
        }

        public async Task<Report> GetOne(int id)
        {
            return await reportRepository.Get(id);
        }

        public async Task<Report> Insert(Report report)
        {
            report.Author = null;
            report.ProblemChallenge = null;
            
            return await reportRepository.Insert(report);
        }

        public async Task<Report> Update(Report report)
        {
            return await reportRepository.Update(report);
        }

        public async Task<Report> Delete(int id)
        {
            return await reportRepository.Delete(id);
        }
    }
}