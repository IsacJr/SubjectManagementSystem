using System.Collections.Generic;
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

        public IEnumerable<Subject> getAll()
        {
            return subjectRepository.GetAll();
        }

        public Subject getOne(int id)
        {
            return subjectRepository.Get(id);
        }

        public Subject Insert(Subject subject)
        {
            subject.Field = null;
            
            return subjectRepository.Insert(subject);
        }

        public Subject Update(Subject subject)
        {
            return subjectRepository.Update(subject);
        }

        public Subject Delete(int id)
        {
            return subjectRepository.Delete(id);
        }
    }
}