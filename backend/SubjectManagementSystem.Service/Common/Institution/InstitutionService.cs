using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IBaseRepository<Institution> institutionRepository;
        public InstitutionService(IBaseRepository<Institution> institutionRepository)
        {
            this.institutionRepository = institutionRepository;
        }

        public IEnumerable<Institution> getAll()
        {
            return institutionRepository.GetAll();
        }

        public Institution getOne(int id)
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