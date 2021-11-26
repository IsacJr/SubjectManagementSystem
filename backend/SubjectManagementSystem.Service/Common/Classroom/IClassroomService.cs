using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IClassroomService
    {
        Classroom getOne(int id);
        IEnumerable<Classroom> getAll();
        Classroom Insert(Classroom classroom);
        Classroom Update(Classroom classroom);  
        Classroom Delete(int id); 
    }
}