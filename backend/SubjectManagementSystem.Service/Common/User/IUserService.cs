using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IUserService
    {
        User GetOne(int id);
        IEnumerable<User> GetAll();
        User Insert(User user);
        User Update(User user);  
        User Delete(int id); 
    }
}