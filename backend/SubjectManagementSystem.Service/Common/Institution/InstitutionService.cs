using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IInstitutionRepository institutionRepository;
        public InstitutionService(IInstitutionRepository institutionRepository)
        {
            this.institutionRepository = institutionRepository;
        }

        public async Task<IEnumerable<Institution>> GetAll()
        {
            return await institutionRepository.GetAll();
        }

        public async Task<Institution> GetOne(int id)
        {
            return await institutionRepository.Get(id);
        }

        public async Task<Institution> Insert(Institution institution)
        {
            institution.Field = null;
            institution.User = null;
            
            return await institutionRepository.Insert(institution);
        }

        public async Task<Institution> Update(Institution user)
        {
            return await institutionRepository.Update(user);
        }

        public async Task<Institution> Delete(int id)
        {
            return await institutionRepository.Delete(id);
        }
    }
}