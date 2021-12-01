using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        public async Task<IEnumerable<Subject>> getAll()
        {
            return await subjectRepository.GetAll();
        }

        public async Task<Subject> getOne(int id)
        {
            return await subjectRepository.Get(id);
        }

        public async Task<Subject> Insert(Subject subject)
        {
            subject.Field = null;
            
            return await subjectRepository.Insert(subject);
        }

        public async Task<Subject> Update(Subject subject)
        {
            return await subjectRepository.Update(subject);
        }

        public async Task<Subject> Delete(int id)
        {
            return await subjectRepository.Delete(id);
        }
    }
}