using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface ITeamService
    {
        Task<Team> getOne(int id);
        Task<IEnumerable<Team>> getAll();
        Task<Team> Insert(Team team);
        Task<Team> Update(Team team);  
        Task<Team> Delete(int id); 
    }
}