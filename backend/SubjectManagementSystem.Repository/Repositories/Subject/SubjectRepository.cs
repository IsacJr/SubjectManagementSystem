using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}