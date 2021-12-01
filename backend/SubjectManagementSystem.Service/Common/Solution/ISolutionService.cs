using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ISolutionService
    {
        Solution GetOne(int id);
        IEnumerable<Solution> GetAll();
        Solution Insert(Solution solution);
        Solution Update(Solution solution);  
        Solution Delete(int id); 
    }
}