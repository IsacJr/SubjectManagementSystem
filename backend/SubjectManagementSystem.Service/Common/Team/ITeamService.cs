using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ITeamService
    {
        Team getOne(int id);
        IEnumerable<Team> getAll();
        Team Insert(Team team);
        Team Update(Team team);  
        Team Delete(int id); 
    }
}