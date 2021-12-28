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

        public async Task<IEnumerable<User>> GetAll(FilterValue filter)
        {
            return await userRepository.GetAll(filter);
        }

        public async Task<User> GetOne(int id)
        {
            return await userRepository.Get(id);
        }

        public async Task<User> Insert(User user)
        {

            user.Institution = null;
            user.Fields = null;
            
            return await userRepository.Insert(user);
        }

        public async Task<User> Update(User user)
        {
            user.Institution = null;
            user.Fields = null;
            return await userRepository.Update(user);
        }

        public async Task<User> Delete(int id)
        {
            return await userRepository.Delete(id);
        }

        public User GetByEmail(string email)
        {
            return userRepository.GetByEmailInfo(email);
        }
    }
}