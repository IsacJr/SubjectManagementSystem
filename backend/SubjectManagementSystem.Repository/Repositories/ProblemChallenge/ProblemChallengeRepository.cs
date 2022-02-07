using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ProblemChallengeRepository : BaseRepository<ProblemChallenge>, IProblemChallengeRepository
    {
        public ProblemChallengeRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<ProblemChallenge>> GetAll(FilterValue filter)
        {
            IQueryable<ProblemChallenge> query = entities;
            if (filter != null)
            {
                if(filter.Challenge != null)
                {
                    query = query.Where<ProblemChallenge>(x => x.IdChallenge == filter.Challenge);
                }
            }
            query = query
                        .Include(x => x.Challenge)
                        .Include(x => x.Team)
                            .ThenInclude(y => y.Members)
                                .ThenInclude(z => z.User)
                        .Include(x => x.Team)
                            .ThenInclude(y => y.Mentor)
                        .Include(x => x.Solution);
            

            return await query.ToListAsync();
        }

    }
}