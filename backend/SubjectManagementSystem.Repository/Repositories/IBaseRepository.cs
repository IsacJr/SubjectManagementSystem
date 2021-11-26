using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IBaseRepository <T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Insert(T entity);
        T Update(T entity);  
        T Delete(int id); 
    }
}