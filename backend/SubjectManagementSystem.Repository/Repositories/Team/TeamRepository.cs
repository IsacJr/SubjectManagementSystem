using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}