using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IProblemChallengeService
    {
        Task<ProblemChallenge> GetOne(int id);
        Task<IEnumerable<ProblemChallenge>> GetAll(FilterValue filter);
        Task<ProblemChallenge> Insert(ProblemChallenge problemChallenge);
        Task<ProblemChallenge> Update(ProblemChallenge problemChallenge);  
        Task<ProblemChallenge> Delete(int id); 
    }
}