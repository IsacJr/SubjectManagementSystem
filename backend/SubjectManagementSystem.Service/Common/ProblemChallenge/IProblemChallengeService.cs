using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IProblemChallengeService
    {
        ProblemChallenge GetOne(int id);
        IEnumerable<ProblemChallenge> GetAll();
        ProblemChallenge Insert(ProblemChallenge problemChallenge);
        ProblemChallenge Update(ProblemChallenge problemChallenge);  
        ProblemChallenge Delete(int id); 
    }
}