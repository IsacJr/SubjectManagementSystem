using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ClassroomService : IClassroomService
    {
        private readonly IClassroomRepository classroomRepository;
        public ClassroomService(IClassroomRepository classroomRepository)
        {
            this.classroomRepository = classroomRepository;
        }

        public IEnumerable<Classroom> getAll()
        {
            return classroomRepository.GetAll();
        }

        public Classroom getOne(int id)
        {
            return classroomRepository.Get(id);
        }

        public Classroom Insert(Classroom classroom)
        {
            classroom.Professor = null;
            classroom.Subject = null;
            classroom.Challenge = null;
            
            return classroomRepository.Insert(classroom);
        }

        public Classroom Update(Classroom classroom)
        {
            return classroomRepository.Update(classroom);
        }

        public Classroom Delete(int id)
        {
            return classroomRepository.Delete(id);
        }
    }
}