using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IChallengeService
    {
        Challenge getOne(int id);
        IEnumerable<Challenge> getAll();
        Challenge Insert(Challenge challenge);
        Challenge Update(Challenge challenge);  
        Challenge Delete(int id); 
    }
}