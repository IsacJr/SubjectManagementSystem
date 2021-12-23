using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IAuthenticationService
    {
        Task<User> getByEmail(string email);
    }
}