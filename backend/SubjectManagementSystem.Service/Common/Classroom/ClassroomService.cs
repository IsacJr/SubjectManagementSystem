using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Classroom>> getAll()
        {
            return await classroomRepository.GetAll();
        }

        public async Task<Classroom> getOne(int id)
        {
            return await classroomRepository.Get(id);
        }

        public async Task<Classroom> Insert(Classroom classroom)
        {
            classroom.Professor = null;
            classroom.Subject = null;
            classroom.Challenge = null;
            
            return await classroomRepository.Insert(classroom);
        }

        public async Task<Classroom> Update(Classroom classroom)
        {
            return await classroomRepository.Update(classroom);
        }

        public async Task<Classroom> Delete(int id)
        {
            return await classroomRepository.Delete(id);
        }
    }
}