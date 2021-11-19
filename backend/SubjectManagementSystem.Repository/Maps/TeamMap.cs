using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class TeamMap : BaseEntityMap<Team>
    {
        public TeamMap() : base("tb_team") { }

        public override void Configure(EntityTypeBuilder<Team> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.Solution).HasColumnName("solution");
            builder.Property(x => x.IdMentor).HasColumnName("id_mentor");

            //foreign keys from another tables
            builder.HasOne(x => x.ProblemChallenge).WithOne(x => x.Team).HasForeignKey<ProblemChallenge>(x => x.IdTeam);
        }
    }
}