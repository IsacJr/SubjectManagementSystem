using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class SolutionRepository : BaseRepository<Solution>, ISolutionRepository
    {
        public SolutionRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public override async Task<Solution> Get(int id)
        {
            return await entities
                            .Include(x => x.Problem)
                                .ThenInclude(y => y.Challenge)
                            .Include(x => x.Team)
                                .ThenInclude(y => y.Members)
                                    .ThenInclude(z => z.User)
                            .Include(x => x.Stages)
                            .SingleOrDefaultAsync(s => s.Id == id);
        }

    }
}