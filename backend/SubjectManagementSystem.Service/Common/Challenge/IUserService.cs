using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class ChallengeService : IChallengeService
    {
        private readonly IBaseRepository<Challenge> userRepository;
        public ChallengeService(IBaseRepository<Challenge> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<Challenge> getAll()
        {
            return userRepository.GetAll();
        }

        public Challenge getOne(int id)
        {
            return userRepository.Get(id);
        }

        public Challenge Insert(Challenge challenge)
        {
            challenge.Institution = null;
            challenge.Field = null;
            challenge.Institution = null;
            challenge.InCharge = null;
            challenge.Creator = null;
            challenge.Contract = null;
            
            return userRepository.Insert(challenge);
        }

        public Challenge Update(Challenge challenge)
        {
            return userRepository.Update(challenge);
        }

        public Challenge Delete(int id)
        {
            return userRepository.Delete(id);
        }
    }
}