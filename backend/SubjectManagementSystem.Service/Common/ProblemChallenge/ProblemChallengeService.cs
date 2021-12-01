using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ProblemChallengeService : IProblemChallengeService
    {
        private readonly IProblemChallengeRepository problemChallengeRepository;
        public ProblemChallengeService(IProblemChallengeRepository problemChallengeRepository)
        {
            this.problemChallengeRepository = problemChallengeRepository;
        }

        public async Task<IEnumerable<ProblemChallenge>> GetAll()
        {
            return await problemChallengeRepository.GetAll();
        }

        public async Task<ProblemChallenge> GetOne(int id)
        {
            return await problemChallengeRepository.Get(id);
        }

        public async Task<ProblemChallenge> Insert(ProblemChallenge problemChallenge)
        {
            problemChallenge.Challenge = null;
            
            return await problemChallengeRepository.Insert(problemChallenge);
        }

        public async Task<ProblemChallenge> Update(ProblemChallenge problemChallenge)
        {
            return await problemChallengeRepository.Update(problemChallenge);
        }

        public async Task<ProblemChallenge> Delete(int id)
        {
            return await problemChallengeRepository.Delete(id);
        }
    }
}