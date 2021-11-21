using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class UserFieldMap : BaseEntityMap<UserField>
    {
        public UserFieldMap() : base("tb_user_field") { }

        public override void Configure(EntityTypeBuilder<UserField> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdUser).HasColumnName("id_user");
            builder.HasOne(x => x.User).WithMany(x => x.Fields).HasForeignKey(x => x.IdUser);
            builder.Property(x => x.IdField).HasColumnName("id_field");
            builder.HasOne(x => x.Field).WithMany().HasForeignKey(x => x.IdField);
            
        }
    }
}