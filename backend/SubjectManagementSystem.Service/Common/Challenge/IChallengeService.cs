using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IChallengeService
    {
        Task<Challenge> getOne(int id);
        Task<IEnumerable<Challenge>> getAll(FilterValue filter);
        Task<Challenge> Insert(Challenge challenge);
        Task<Challenge> Update(Challenge challenge);  
        Task<Challenge> Delete(int id); 
    }
}