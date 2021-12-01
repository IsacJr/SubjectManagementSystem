using System.Collections.Generic;
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

        public IEnumerable<ProblemChallenge> GetAll()
        {
            return problemChallengeRepository.GetAll();
        }

        public ProblemChallenge GetOne(int id)
        {
            return problemChallengeRepository.Get(id);
        }

        public ProblemChallenge Insert(ProblemChallenge problemChallenge)
        {
            problemChallenge.Challenge = null;
            
            return problemChallengeRepository.Insert(problemChallenge);
        }

        public ProblemChallenge Update(ProblemChallenge problemChallenge)
        {
            return problemChallengeRepository.Update(problemChallenge);
        }

        public ProblemChallenge Delete(int id)
        {
            return problemChallengeRepository.Delete(id);
        }
    }
}