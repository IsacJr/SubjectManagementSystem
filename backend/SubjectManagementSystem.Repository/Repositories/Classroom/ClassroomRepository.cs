using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<Classroom>> GetAll(FilterValue filter)
        {
            IQueryable<Classroom> query = entities;
            
            query = query
                        .Include(x => x.Professor)
                        .Include(x => x.Subject);

            if (filter != null)
            {
                if (filter.Field != null)
                {
                    query = query.Where<Classroom>(x => x.Subject.IdField == filter.Field);
                }
                if(filter.Professor != null)
                {
                    query = query.Where<Classroom>(x => x.IdProfessor == filter.Professor);
                }
            }
            

            return await query.ToListAsync();
        }

        public override async Task<Classroom> Get(int id)
        {
            return await entities
                            .Include(x => x.Professor)
                            .Include(x => x.Subject)
                            .SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}