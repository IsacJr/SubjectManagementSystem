using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IUserService
    {
        Task<User> GetOne(int id);
        Task<IEnumerable<User>> GetAll(FilterValue filter);
        Task<User> Insert(User user);
        Task<User> Update(User user);  
        Task<User> Delete(int id);
        Task<User> GetByEmail(string email);
    }
}