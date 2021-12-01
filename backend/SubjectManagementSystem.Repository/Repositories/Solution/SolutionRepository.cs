using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class SolutionRepository : BaseRepository<Solution>, ISolutionRepository
    {
        public SolutionRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}