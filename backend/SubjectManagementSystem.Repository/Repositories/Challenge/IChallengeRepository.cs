using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IChallengeRepository : IBaseRepository<Challenge>
    {
        Task<IEnumerable<Challenge>> GetAll(FilterValue filter);
        new Task<Challenge> Get(int id);
    }
}