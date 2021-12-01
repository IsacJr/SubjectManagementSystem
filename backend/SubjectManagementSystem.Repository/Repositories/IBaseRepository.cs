using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IBaseRepository <T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Insert(T entity);
        Task<T> Update(T entity);  
        Task<T> Delete(int id); 
    }
}