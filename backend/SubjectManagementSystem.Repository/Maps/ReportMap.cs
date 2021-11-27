
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
            builder.Property(x => x.IdChallenge).HasColumnName("id_challenge");
            builder.HasOne(x => x.Challenge).WithMany().HasForeignKey(x => x.IdChallenge);
            builder.Property(x => x.IdAuthor).HasColumnName("id_author");
            builder.HasOne(x => x.Author).WithMany().HasForeignKey(x => x.IdAuthor);            
        }
    }
}