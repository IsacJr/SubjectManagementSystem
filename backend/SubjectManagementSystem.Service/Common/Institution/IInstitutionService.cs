using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IInstitutionService
    {
        Institution getOne(int id);
        IEnumerable<Institution> getAll();
        Institution Insert(Institution institution);
        Institution Update(Institution institution);  
        Institution Delete(int id); 
    }
}