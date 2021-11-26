using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> userRepository;
        public UserService(IBaseRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> getAll()
        {
            return userRepository.GetAll();
        }

        public User getOne(int id)
        {
            return userRepository.Get(id);
        }

        public User Insert(User user)
        {
            user.ChallengeCreator = null;
            user.ChallengeInCharge = null;
            user.Institution = null;
            user.Fields = null;
            
            return userRepository.Insert(user);
        }

        public User Update(User user)
        {
            return userRepository.Update(user);
        }

        public User Delete(int id)
        {
            return userRepository.Delete(id);
        }
    }
}