using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}