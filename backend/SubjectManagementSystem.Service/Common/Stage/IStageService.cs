using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IStageService
    {
        Task<Stage> GetOne(int id);
        Task<IEnumerable<Stage>> GetAll();
        Task<Stage> Insert(Stage stage);
        Task<Stage> Update(Stage stage);  
        Task<Stage> Delete(int id); 
    }
}