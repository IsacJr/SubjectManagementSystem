using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class FieldMap : BaseEntityMap<Field>
    {
        public FieldMap() : base("tb_field") { }

        public override void Configure(EntityTypeBuilder<Field> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name");

            
            //foreign keys from another tables
            builder.HasOne(x => x.Institution).WithOne(x => x.Field).HasForeignKey<Institution>(x => x.IdField);
        }
    }
}