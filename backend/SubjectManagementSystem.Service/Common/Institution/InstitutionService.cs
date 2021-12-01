using System.Collections.Generic;
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

        public IEnumerable<Institution> GetAll()
        {
            return institutionRepository.GetAll();
        }

        public Institution GetOne(int id)
        {
            return institutionRepository.Get(id);
        }

        public Institution Insert(Institution institution)
        {
            institution.Field = null;
            institution.User = null;
            institution.Challenge = null;
            
            return institutionRepository.Insert(institution);
        }

        public Institution Update(Institution user)
        {
            return institutionRepository.Update(user);
        }

        public Institution Delete(int id)
        {
            return institutionRepository.Delete(id);
        }
    }
}