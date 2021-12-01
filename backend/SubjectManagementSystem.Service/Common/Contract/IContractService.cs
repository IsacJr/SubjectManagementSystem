using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IContractService
    {
        Task<Contract> GetOne(int id);
        Task<IEnumerable<Contract>> GetAll();
        Task<Contract> Insert(Contract contract);
        Task<Contract> Update(Contract contract);  
        Task<Contract> Delete(int id); 
    }
}