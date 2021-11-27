using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class StageMap : BaseEntityMap<Stage>
    {
        public StageMap() : base("tb_stage") { }

        public override void Configure(EntityTypeBuilder<Stage> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Link).HasColumnName("link");

            builder.Property(x => x.IdSolution).HasColumnName("id_solution");
            builder.HasOne(x => x.Solution).WithMany(x => x.Stages).HasForeignKey(x => x.IdSolution);
        }
    }
}