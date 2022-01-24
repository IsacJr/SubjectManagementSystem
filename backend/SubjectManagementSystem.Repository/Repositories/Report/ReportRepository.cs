using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        public ReportRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<Report>> GetAll(FilterValue filter)
        {
            IQueryable<Report> query = entities;
            query = query.Include(x => x.ProblemChallenge);
            query = query.Include(x => x.Author);

            return await query.ToListAsync();
        }

    }
}