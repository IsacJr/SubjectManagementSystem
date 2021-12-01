using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class StageService : IStageService
    {
        private readonly IStageRepository stageRepository;
        public StageService(IStageRepository stageRepository)
        {
            this.stageRepository = stageRepository;
        }

        public async Task<IEnumerable<Stage>> GetAll()
        {
            return await stageRepository.GetAll();
        }

        public async Task<Stage> GetOne(int id)
        {
            return await stageRepository.Get(id);
        }

        public async Task<Stage> Insert(Stage stage)
        {
            stage.Solution = null;
            
            return await stageRepository.Insert(stage);
        }

        public async Task<Stage> Update(Stage stage)
        {
            return await stageRepository.Update(stage);
        }

        public async Task<Stage> Delete(int id)
        {
            return await stageRepository.Delete(id);
        }
    }
}