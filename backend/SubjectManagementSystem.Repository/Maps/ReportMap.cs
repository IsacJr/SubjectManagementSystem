
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
            builder.Property(x => x.IdChallenge).HasColumnName("challenge");
            builder.HasOne(x => x.Challenge).WithMany().HasForeignKey(x => x.IdChallenge);
        }
    }
}