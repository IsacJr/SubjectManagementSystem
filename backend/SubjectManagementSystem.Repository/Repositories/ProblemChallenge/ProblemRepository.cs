using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ProblemRepository : BaseRepository<ProblemChallenge>, IProblemRepository
    {
        public ProblemRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}