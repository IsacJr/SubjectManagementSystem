using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await userRepository.GetAll();
        }

        public async Task<User> GetOne(int id)
        {
            return await userRepository.Get(id);
        }

        public async Task<User> Insert(User user)
        {
            user.ChallengeCreator = null;
            user.ChallengeInCharge = null;
            user.Institution = null;
            user.Fields = null;
            
            return await userRepository.Insert(user);
        }

        public async Task<User> Update(User user)
        {
            return await userRepository.Update(user);
        }

        public async Task<User> Delete(int id)
        {
            return await userRepository.Delete(id);
        }
    }
}