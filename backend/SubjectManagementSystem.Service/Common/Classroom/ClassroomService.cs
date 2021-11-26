using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ClassroomService : IClassroomService
    {
        private readonly IBaseRepository<Classroom> userRepository;
        public ClassroomService(IBaseRepository<Classroom> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<Classroom> getAll()
        {
            return userRepository.GetAll();
        }

        public Classroom getOne(int id)
        {
            return userRepository.Get(id);
        }

        public Classroom Insert(Classroom classroom)
        {
            classroom.Professor = null;
            classroom.Subject = null;
            classroom.Challenge = null;
            
            return userRepository.Insert(classroom);
        }

        public Classroom Update(Classroom classroom)
        {
            return userRepository.Update(classroom);
        }

        public Classroom Delete(int id)
        {
            return userRepository.Delete(id);
        }
    }
}