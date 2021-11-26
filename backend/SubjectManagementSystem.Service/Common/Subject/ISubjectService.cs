using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ISubjectService
    {
        Subject getOne(int id);
        IEnumerable<Subject> getAll();
        Subject Insert(Subject subject);
        Subject Update(Subject subject);  
        Subject Delete(int id); 
    }
}