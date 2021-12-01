using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class InstitutionRepository : BaseRepository<Institution>, IInstitutionRepository
    {
        public InstitutionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}