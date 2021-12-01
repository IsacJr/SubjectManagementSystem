using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        public ReportRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}