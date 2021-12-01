using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IInstitutionService
    {
        Task<Institution> GetOne(int id);
        Task<IEnumerable<Institution>> GetAll();
        Task<Institution> Insert(Institution institution);
        Task<Institution> Update(Institution institution);  
        Task<Institution> Delete(int id); 
    }
}