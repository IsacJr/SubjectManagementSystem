using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class ProblemChallengeMap : BaseEntityMap<ProblemChallenge>
    {
        public ProblemChallengeMap() : base("tb_problem_challenge") { }

        public override void Configure(EntityTypeBuilder<ProblemChallenge> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.Detail).HasColumnName("detail");

            builder.Property(x => x.IdChallenge).HasColumnName("id_challenge");
            builder.HasOne(x => x.Challenge).WithMany().HasForeignKey(x => x.IdChallenge);

            builder.Property(x => x.IdTeam).HasColumnName("id_team");
            
        }
    }
}