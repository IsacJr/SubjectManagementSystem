using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IClassroomService
    {
        Task<Classroom> getOne(int id);
        Task<IEnumerable<Classroom>> getAll();
        Task<Classroom> Insert(Classroom classroom);
        Task<Classroom> Update(Classroom classroom);  
        Task<Classroom> Delete(int id); 
    }
}