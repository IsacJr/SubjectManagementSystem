using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ISubjectService
    {
        Task<Subject> getOne(int id);
        Task<IEnumerable<Subject>> getAll();
        Task<Subject> Insert(Subject subject);
        Task<Subject> Update(Subject subject);  
        Task<Subject> Delete(int id); 
    }
}