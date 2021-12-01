using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IContractService
    {
        Contract GetOne(int id);
        IEnumerable<Contract> GetAll();
        Contract Insert(Contract contract);
        Contract Update(Contract contract);  
        Contract Delete(int id); 
    }
}