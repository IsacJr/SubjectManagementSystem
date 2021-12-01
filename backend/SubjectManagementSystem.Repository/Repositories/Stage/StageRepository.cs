using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class StageRepository : BaseRepository<Stage>, IStageRepository
    {
        public StageRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    }
}