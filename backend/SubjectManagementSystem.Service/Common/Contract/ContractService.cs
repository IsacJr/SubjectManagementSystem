using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository contractRepository;
        public ContractService(IContractRepository contractRepository)
        {
            this.contractRepository = contractRepository;
        }

        public async Task<IEnumerable<Contract>> GetAll()
        {
            return await contractRepository.GetAll();
        }

        public async Task<Contract> GetOne(int id)
        {
            return await contractRepository.Get(id);
        }

        public async Task<Contract> Insert(Contract contract)
        {
            contract.Challenge = null;
            contract.Classroom = null;
            
            return await contractRepository.Insert(contract);
        }

        public async Task<Contract> Update(Contract contract)
        {
            return await contractRepository.Update(contract);
        }

        public async Task<Contract> Delete(int id)
        {
            return await contractRepository.Delete(id);
        }
    }
}