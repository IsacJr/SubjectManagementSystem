using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class InstitutionMap : BaseEntityMap<Institution>
    {
        public InstitutionMap() : base("tb_institution") { }

        public override void Configure(EntityTypeBuilder<Institution> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.EmployerIdentificationNumber).HasColumnName("employer_identification_number");
            builder.Property(x => x.ZipCode).HasColumnName("zip_code");
            builder.Property(x => x.Street).HasColumnName("street");
            builder.Property(x => x.City).HasColumnName("city");
            builder.Property(x => x.State).HasColumnName("state");
            builder.Property(x => x.IdField).HasColumnName("id_field");


            //foreign keys from another table
            builder.HasOne(x => x.User).WithOne(x => x.Institution).HasForeignKey<User>(x => x.IdInstitution);
            builder.HasOne(x => x.Challenge).WithOne(x => x.Institution).HasForeignKey<Challenge>(x => x.IdInstitution);

            
        }
    }
}