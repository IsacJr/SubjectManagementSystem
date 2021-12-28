using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IContractRepository : IBaseRepository<Contract>
    {
        Task<Contract> ProposePartnership(Contract contract);
    }
}