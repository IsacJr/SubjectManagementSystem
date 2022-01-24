
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ReportMap : BaseEntityMap<Report>
    {
        public ReportMap() : base("tb_report") { }

        public override void Configure(EntityTypeBuilder<Report> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.IdProblemChallenge).HasColumnName("id_problem_challenge");
            builder.HasOne(x => x.ProblemChallenge).WithMany().HasForeignKey(x => x.IdProblemChallenge);
            builder.Property(x => x.IdAuthor).HasColumnName("id_author");
            builder.HasOne(x => x.Author).WithMany().HasForeignKey(x => x.IdAuthor);            
        }
    }
}