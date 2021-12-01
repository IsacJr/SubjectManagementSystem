using System.Collections.Generic;
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

        public IEnumerable<Stage> GetAll()
        {
            return stageRepository.GetAll();
        }

        public Stage GetOne(int id)
        {
            return stageRepository.Get(id);
        }

        public Stage Insert(Stage stage)
        {
            stage.Solution = null;
            
            return stageRepository.Insert(stage);
        }

        public Stage Update(Stage stage)
        {
            return stageRepository.Update(stage);
        }

        public Stage Delete(int id)
        {
            return stageRepository.Delete(id);
        }
    }
}