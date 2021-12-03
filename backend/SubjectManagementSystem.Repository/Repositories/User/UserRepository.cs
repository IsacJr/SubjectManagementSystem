using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;
using System.Linq;

namespace SubjectManagementSystem.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<User>> GetAll(FilterValue filter)
        {
            IQueryable<User> query = entities;
            if (filter != null)
            {
                if(filter.UserType != null)
                {
                    query = query.Where<User>(x => (int?)x.Type == filter.UserType);
                }
            }

            return await query.ToListAsync();
        }


    }
}