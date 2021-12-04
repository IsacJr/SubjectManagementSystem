using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Challenge>> getAll(FilterValue filter)
        {
            return await challengeRepository.GetAll(filter);
        }

        public async Task<Challenge> getOne(int id)
        {
            return await challengeRepository.Get(id);
        }

        public async Task<Challenge> Insert(Challenge challenge)
        {
            challenge.Institution = null;
            challenge.Field = null;
            challenge.Institution = null;
            challenge.InCharge = null;
            challenge.Creator = null;
            challenge.Contract = null;
            
            return await challengeRepository.Insert(challenge);
        }

        public async Task<Challenge> Update(Challenge challenge)
        {
            return await challengeRepository.Update(challenge);
        }

        public async Task<Challenge> Delete(int id)
        {
            return await challengeRepository.Delete(id);
        }
    }
}