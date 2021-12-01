using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ChallengeRepository : BaseRepository<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    }
}