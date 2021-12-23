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
                if(filter.Institution != null)
                {
                    query = query.Where<User>(x => x.IdInstitution == filter.Institution);
                }
                if(filter.Page != null)
                {
                    filter.Page = filter.Page <= 0 ? 1 : filter.Page;
                    query = query.Skip((((int)filter.Page) - 1) * PageSize).Take(PageSize);
                }
            }
            query = query.Include(x => x.Institution);
            

            return await query.ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            return await entities.SingleOrDefaultAsync(s => s.Email == email);
        }


    }
}