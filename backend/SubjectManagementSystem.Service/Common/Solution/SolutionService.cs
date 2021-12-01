using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class SolutionService : ISolutionService
    {
        private readonly ISolutionRepository solutionRepository;
        public SolutionService(ISolutionRepository solutionRepository)
        {
            this.solutionRepository = solutionRepository;
        }

        public IEnumerable<Solution> GetAll()
        {
            return solutionRepository.GetAll();
        }

        public Solution GetOne(int id)
        {
            return solutionRepository.Get(id);
        }

        public Solution Insert(Solution solution)
        {
            solution.Problem = null;
            solution.Team = null;
            
            return solutionRepository.Insert(solution);
        }

        public Solution Update(Solution solution)
        {
            return solutionRepository.Update(solution);
        }

        public Solution Delete(int id)
        {
            return solutionRepository.Delete(id);
        }
    }
}