using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ChallengeRepository : BaseRepository<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<Challenge>> GetAll(FilterValue filter)
        {
            IQueryable<Challenge> query = entities;
            if (filter != null)
            {
                if(filter.Institution != null)
                {
                    query = query.Where<Challenge>(x => x.IdInstitution == filter.Institution);
                }
                else if(filter.Status != null)
                {
                    query = query.Where<Challenge>(x => (int?)x.Status == filter.Status);
                }
                else if(filter.Field != null)
                {
                    query = query.Where<Challenge>(x => x.IdField == filter.Field);
                }
            }
            query = query.Include(x => x.Institution);
            query = query.Include(x => x.Field);
            query = query.Include(x => x.InCharge);
            query = query.Include(x => x.Creator);
            query = query.Include(x => x.Classroom);
            

            return await query.ToListAsync();
        }

    }
}