using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IUserService
    {
        User getOne(int id);
        IEnumerable<User> getAll();
        User Insert(User user);
        User Update(User user);  
        User Delete(int id); 
    }
}