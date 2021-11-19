using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class SubjectMap : BaseEntityMap<Subject>
    {
        public SubjectMap() : base("tb_subject") { }

        public override void Configure(EntityTypeBuilder<Subject> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.Syllabus).HasColumnName("syllabus");

            //foreign keys relations from another tables
            builder.HasOne(x => x.Classroom).WithOne(x => x.Subject).HasForeignKey<Classroom>(x => x.IdSubject);
            
        }
    }
}