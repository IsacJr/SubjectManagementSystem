using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ChallengeService : IChallengeService
    {
        private readonly IChallengeRepository challengeRepository;
        public ChallengeService(IChallengeRepository challengeRepository)
        {
            this.challengeRepository = challengeRepository;
        }

        public IEnumerable<Challenge> getAll()
        {
            return challengeRepository.GetAll();
        }

        public Challenge getOne(int id)
        {
            return challengeRepository.Get(id);
        }

        public Challenge Insert(Challenge challenge)
        {
            challenge.Institution = null;
            challenge.Field = null;
            challenge.Institution = null;
            challenge.InCharge = null;
            challenge.Creator = null;
            challenge.Contract = null;
            
            return challengeRepository.Insert(challenge);
        }

        public Challenge Update(Challenge challenge)
        {
            return challengeRepository.Update(challenge);
        }

        public Challenge Delete(int id)
        {
            return challengeRepository.Delete(id);
        }
    }
}