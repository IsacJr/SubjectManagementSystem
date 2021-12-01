using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class FieldRepository : BaseRepository<Field>, IFieldRepository
    {
        public FieldRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}