using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class SolutionMap : BaseEntityMap<Solution>
    {
        public SolutionMap() : base("tb_solution") { }

        public override void Configure(EntityTypeBuilder<Solution> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdProblem).HasColumnName("id_problem");
            
            builder.Property(x => x.IdTeam).HasColumnName("id_team");
            builder.HasOne(x => x.Team).WithMany().HasForeignKey(x => x.IdTeam);
        }
    }
}