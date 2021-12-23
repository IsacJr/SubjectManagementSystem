using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface IClassroomRepository : IBaseRepository<Classroom>
    {
        Task<IEnumerable<Classroom>> GetAll(FilterValue filter);
        new Task<Classroom> Get(int id);
    }
}