using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IFieldService
    {
        Field GetOne(int id);
        IEnumerable<Field> GetAll();
        Field Insert(Field contract);
        Field Update(Field contract);  
        Field Delete(int id); 
    }
}