using System.Collections.Generic;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Service
{
    public class FieldService : IFieldService
    {
        private readonly IFieldRepository fieldRepository;
        public FieldService(IFieldRepository fieldRepository)
        {
            this.fieldRepository = fieldRepository;
        }

        public IEnumerable<Field> GetAll()
        {
            return fieldRepository.GetAll();
        }

        public Field GetOne(int id)
        {
            return fieldRepository.Get(id);
        }

        public Field Insert(Field field)
        {
            field.Institution = null;
            
            return fieldRepository.Insert(field);
        }

        public Field Update(Field field)
        {
            return fieldRepository.Update(field);
        }

        public Field Delete(int id)
        {
            return fieldRepository.Delete(id);
        }
    }
}