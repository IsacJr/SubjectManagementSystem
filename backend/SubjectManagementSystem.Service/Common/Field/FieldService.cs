using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Task<IEnumerable<Field>> GetAll()
        {
            return fieldRepository.GetAll();
        }

        public async Task<Field> GetOne(int id)
        {
            return await fieldRepository.Get(id);
        }

        public async Task<Field> Insert(Field field)
        {
            field.Institution = null;
            
            return await fieldRepository.Insert(field);
        }

        public async Task<Field> Update(Field field)
        {
            return await fieldRepository.Update(field);
        }

        public async Task<Field> Delete(int id)
        {
            return await fieldRepository.Delete(id);
        }
    }
}