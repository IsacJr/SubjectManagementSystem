using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository teamRepository;
        public TeamService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public async Task<IEnumerable<Team>> getAll(FilterValue filter)
        {
            return await teamRepository.GetAll(filter);
        }

        public async Task<Team> getOne(int id)
        {
            return await teamRepository.Get(id);
        }

        public async Task<Team> Insert(TeamDto teamDto)
        {
            
            return await teamRepository.Insert(teamDto);
        }

        public async Task<Team> Update(Team team)
        {
            return await teamRepository.Update(team);
        }

        public async Task<Team> Delete(int id)
        {
            return await teamRepository.Delete(id);
        }
    }
}