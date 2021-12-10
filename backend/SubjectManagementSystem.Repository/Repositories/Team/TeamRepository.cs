using System;
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

        public async Task<IEnumerable<Team>> GetAll(FilterValue filter)
        {
            IQueryable<Team> query = entities;

            query = query
                        .Include(x => x.Members)
                            .ThenInclude(y => y.User)
                        .Include(x => x.Members)
                            .ThenInclude(y => y.Team);
            

            return await query.ToListAsync();
        }

        public async Task<Team> Insert(TeamDto TeamDto)
        {
            
            try
            {
                using(var transaction = await dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var userList = await dbContext.Users.Where(x => TeamDto.IdUserList.Contains(x.Id)).ToListAsync();

                        var userTeamList = new List<UserTeam>();
                        foreach(var userTeam in userList)
                        {
                            var aux = new UserTeam {
                                User = userTeam,
                                Team = TeamDto.Team
                            };
                            userTeamList.Add(aux);
                        }
                        var team = TeamDto.Team;
                        team.Members = userTeamList;

                        await dbContext.Teams.AddAsync(team);
                        await dbContext.SaveChangesAsync();

                        await transaction.CommitAsync();
                        return team;

                    }catch(Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}