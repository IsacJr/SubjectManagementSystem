using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ProblemChallengeRepository : BaseRepository<ProblemChallenge>, IProblemChallengeRepository
    {
        public ProblemChallengeRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}