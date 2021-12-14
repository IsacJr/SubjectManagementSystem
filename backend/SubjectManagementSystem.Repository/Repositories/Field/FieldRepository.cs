using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class FieldRepository : BaseRepository<Field>, IFieldRepository
    {
        public FieldRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public override async Task<IEnumerable<Field>> GetAll()
        {
            IQueryable<Field> query = entities;
            query = query.Include(x => x.Institution);
            

            return await query.ToListAsync();
        }

    }
}