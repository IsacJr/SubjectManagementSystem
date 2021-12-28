using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IProblemChallengeRepository : IBaseRepository<ProblemChallenge>
    {
        Task<IEnumerable<ProblemChallenge>> GetAll(FilterValue filter);
    }
}