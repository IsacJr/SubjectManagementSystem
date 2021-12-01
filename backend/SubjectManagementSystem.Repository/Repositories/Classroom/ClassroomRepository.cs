using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}