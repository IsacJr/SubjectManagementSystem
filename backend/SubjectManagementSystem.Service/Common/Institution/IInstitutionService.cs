using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IInstitutionService
    {
        Institution GetOne(int id);
        IEnumerable<Institution> GetAll();
        Institution Insert(Institution institution);
        Institution Update(Institution institution);  
        Institution Delete(int id); 
    }
}