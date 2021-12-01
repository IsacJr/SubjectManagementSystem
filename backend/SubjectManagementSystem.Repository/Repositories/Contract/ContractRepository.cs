using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ContractRepository : BaseRepository<Contract>, IContractRepository
    {
        public ContractRepository(ApplicationDbContext dbContext) : base(dbContext) {}


    }
}