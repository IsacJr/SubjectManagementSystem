using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public interface ISolutionRepository : IBaseRepository<Solution>
    {
        new Task<Solution> Get(int id);
    }
}