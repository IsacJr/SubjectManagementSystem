using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ISolutionService
    {
        Task<Solution> GetOne(int id);
        Task<IEnumerable<Solution>> GetAll();
        Task<Solution> Insert(Solution solution);
        Task<Solution> Update(Solution solution);  
        Task<Solution> Delete(int id); 
    }
}