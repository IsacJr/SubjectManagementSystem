using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Solution>> GetAll()
        {
            return await solutionRepository.GetAll();
        }

        public async Task<Solution> GetOne(int id)
        {
            return await solutionRepository.Get(id);
        }

        public async Task<Solution> Insert(Solution solution)
        {
            solution.Problem = null;
            solution.Team = null;
            
            return await solutionRepository.Insert(solution);
        }

        public async Task<Solution> Update(Solution solution)
        {
            return await solutionRepository.Update(solution);
        }

        public async Task<Solution> Delete(int id)
        {
            return await solutionRepository.Delete(id);
        }
    }
}