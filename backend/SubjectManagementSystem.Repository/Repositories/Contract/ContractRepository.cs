using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ContractRepository : BaseRepository<Contract>, IContractRepository
    {
        public ContractRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<Contract> ProposePartnership(Contract contract)
        {
            try
            {
                using(var transaction = await dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var challengeAlreadySaved = await dbContext.Challenges.SingleOrDefaultAsync(c => c.Id == contract.IdChallenge);
                        if (challengeAlreadySaved == null) throw new ArgumentNullException("entity");

                        challengeAlreadySaved.Status = StatusEnum.OnProgress;

                        dbContext.Update(challengeAlreadySaved);
                        await dbContext.AddAsync(contract);
                        await dbContext.SaveChangesAsync();
                        
                        await transaction.CommitAsync();
                        return contract;
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