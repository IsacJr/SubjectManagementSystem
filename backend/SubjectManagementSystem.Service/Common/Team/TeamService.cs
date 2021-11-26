using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class TeamService : ITeamService
    {
        private readonly IBaseRepository<Team> teamRepository;
        public TeamService(IBaseRepository<Team> teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public IEnumerable<Team> getAll()
        {
            return teamRepository.GetAll();
        }

        public Team getOne(int id)
        {
            return teamRepository.Get(id);
        }

        public Team Insert(Team team)
        {
            team.Mentor = null;
            team.Members = null;
            team.ProblemChallenge = null;
            
            return teamRepository.Insert(team);
        }

        public Team Update(Team team)
        {
            return teamRepository.Update(team);
        }

        public Team Delete(int id)
        {
            return teamRepository.Delete(id);
        }
    }
}