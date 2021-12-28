using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class ContractMap : BaseEntityMap<Contract>
    {
        public ContractMap() : base("tb_contract") { }

        public override void Configure(EntityTypeBuilder<Contract> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdChallenge).HasColumnName("id_challenge");
            builder.Property(x => x.IdClassroom).HasColumnName("id_classroom");
            builder.HasOne(x => x.Classroom).WithMany().HasForeignKey(x => x.IdClassroom);
        }
    }
}