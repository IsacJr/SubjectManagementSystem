using System.Collections.Generic;
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

        public IEnumerable<Contract> getAll()
        {
            return contractRepository.GetAll();
        }

        public Contract getOne(int id)
        {
            return contractRepository.Get(id);
        }

        public Contract Insert(Contract contract)
        {
            contract.Challenge = null;
            contract.Classroom = null;
            
            return contractRepository.Insert(contract);
        }

        public Contract Update(Contract contract)
        {
            return contractRepository.Update(contract);
        }

        public Contract Delete(int id)
        {
            return contractRepository.Delete(id);
        }
    }
}