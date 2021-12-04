using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<Team>> GetAll(FilterValue filter){
            IQueryable<Team> query = entities;

            query = query.Include(x => x.Members);
            

            return await query.ToListAsync();
        }
    }
}