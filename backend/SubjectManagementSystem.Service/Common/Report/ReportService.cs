using System.Collections.Generic;
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

        public IEnumerable<Report> GetAll()
        {
            return reportRepository.GetAll();
        }

        public Report GetOne(int id)
        {
            return reportRepository.Get(id);
        }

        public Report Insert(Report report)
        {
            report.Author = null;
            report.Challenge = null;
            
            return reportRepository.Insert(report);
        }

        public Report Update(Report report)
        {
            return reportRepository.Update(report);
        }

        public Report Delete(int id)
        {
            return reportRepository.Delete(id);
        }
    }
}