using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IFieldService
    {
        Task<Field> GetOne(int id);
        Task<IEnumerable<Field>> GetAll();
        Task<Field> Insert(Field contract);
        Task<Field> Update(Field contract);  
        Task<Field> Delete(int id); 
    }
}