using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IContractService
    {
        Contract getOne(int id);
        IEnumerable<Contract> getAll();
        Contract Insert(Contract contract);
        Contract Update(Contract contract);  
        Contract Delete(int id); 
    }
}