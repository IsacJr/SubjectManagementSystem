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
            query = query
                        .Include(x => x.ProblemChallenge)
                            .ThenInclude(y => y.Challenge)
                        .Include(x => x.Author);

            if (filter != null)
            {
                if (filter.Field != null)
                {
                    query = query.Where<Report>(x => x.ProblemChallenge.Challenge.IdField == filter.Field);
                }
                if(filter.Institution != null)
                {
                    query = query.Where<Report>(x => x.ProblemChallenge.Challenge.IdInstitution == filter.Institution);
                }
            }

            return await query.ToListAsync();
        }

    }
}