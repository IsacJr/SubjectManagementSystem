using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IStageService
    {
        Stage GetOne(int id);
        IEnumerable<Stage> GetAll();
        Stage Insert(Stage stage);
        Stage Update(Stage stage);  
        Stage Delete(int id); 
    }
}